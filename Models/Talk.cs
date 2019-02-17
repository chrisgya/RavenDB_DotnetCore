using System;
using Newtonsoft.Json;

namespace RavenDB_DotNetCore_App.Models
{
     public class Talk
    {
        public Talk()
        {
            Tags = new string[0];
        }

        // e.g. Talks/1
        public string Id { get; set; }

        // Strip prefix
        [JsonIgnore]
        public string ClientId => DocumentId.NoPrefix(Id);

        public string Headline { get; set; }

        public string Description { get; set; }

        public string Event { get; set; }

        public string Speaker { get; set; }

        public DateTime Published { get; set; }

        public string[] Tags { get; set; }
    }

}