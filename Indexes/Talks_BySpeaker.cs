using System.Linq;
using Raven.Client.Documents.Indexes;
using RavenDB_DotNetCore_App.Models;

namespace RavenDB_DotNetCore_App.Indexes
{
    public class Talks_BySpeaker : AbstractIndexCreationTask<Talk>
    {
        public Talks_BySpeaker()
        {
            Map = talks =>
                from talk in talks
                select new
                {
                    talk.Speaker
                };
        }
    }
}