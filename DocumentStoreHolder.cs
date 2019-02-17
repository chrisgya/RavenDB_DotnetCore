using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Raven.Client.Documents;
using Raven.Client.Documents.Indexes;
using Raven.Client.ServerWide;
using Raven.Client.ServerWide.Operations;
using RavenDB_DotNetCore_App.Indexes;
using RavenDB_DotNetCore_App.Models;

namespace RavenDB_DotNetCore_App
{
     public interface IDocumentStoreHolder
    {
        IDocumentStore Store { get; }
    }

    public class DocumentStoreHolder : IDocumentStoreHolder
    {
        private readonly ILogger<DocumentStoreHolder> _logger;

        public DocumentStoreHolder(IOptions<RavenSettings> ravenSettings, ILogger<DocumentStoreHolder> logger)
        {
            this._logger = logger;
            var settings = ravenSettings.Value;

            Store = new DocumentStore()
            {
                Urls = new[] { settings.Url },
                Database = settings.Database
            };

            Store.Initialize();

            this._logger.LogInformation("🌟  Initialized RavenDB document store for {0} at {1}",
                settings.Database, settings.Url);

            // Create if not exists
            CreateDatabaseIfNotExists();

            // Create indexes
            IndexCreation.CreateIndexes(typeof(Talks_BySpeaker).Assembly, Store);
        }

        public DocumentStoreHolder(IDocumentStore store) 
        {
            this.Store = store;
               
        }
                public IDocumentStore Store { get; }

#region Nothing to see here!

        private void CreateDatabaseIfNotExists()
        {
            var database = Store.Database;
            var dbRecord = Store.Maintenance.Server.Send(new GetDatabaseRecordOperation(database));

            if (dbRecord == null)
            {
                this._logger.LogInformation("RavenDB database does not exist, creating and seeding with initial data");

                // Create database
                var newDatabase = new DatabaseRecord(database);

                var createResult = Store.Maintenance.Server.Send(new CreateDatabaseOperation(newDatabase));

                if (createResult.Name != null)
                {
                    // Seed database
                    var talks = CsvData.LoadTalks();
                    var speakers = CsvData.LoadSpeakers();

                    // old => new speaker ID map
                    var speakerIdMap = new Dictionary<string, string>();

                    using (var session = Store.OpenSession())
                    {
                        foreach (var speaker in speakers)
                        {
                            var oldId = speaker.Id;
                            speaker.Id = null;
                            session.Store(speaker);
                            speakerIdMap.Add(oldId, speaker.Id);
                        }

                        foreach (var talk in talks)
                        {
                            talk.Id = null;
                            talk.Speaker = speakerIdMap[talk.Speaker];
                            session.Store(talk);
                        }
                        session.SaveChanges();
                    }

                    this._logger.LogInformation("Seeded database with {0} talks", talks.Count);
                    this._logger.LogInformation("Seeded database with {0} speakers", speakers.Count);
                }
            }
        }
    }
#endregion

}