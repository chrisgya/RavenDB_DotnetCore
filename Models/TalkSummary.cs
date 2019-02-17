using System;
using Newtonsoft.Json;

namespace RavenDB_DotNetCore_App.Models
{
     
    public class TalkSummary
    {
        public string Id { get; set; }

        // Strip prefix
        public string ClientId => DocumentId.NoPrefix(Id);        

        public string Headline { get; set; }

        public string Description { get; set; }

        public string Speaker { get; set; }

        public string SpeakerName { get; set; }

        public DateTime Published { get; set; }
    }

}