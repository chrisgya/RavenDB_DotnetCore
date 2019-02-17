using System;
using Newtonsoft.Json;

namespace RavenDB_DotNetCore_App.Models
{
    
    public class UpdatedTalk
    {
        public string Headline { get; set; }

        public string Description { get; set; }

        public string Speaker { get; set; }
    }
}