using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XamarinAllianceApp.Models
{
    public class Movie
    {
        Int32 id;
        string title;
        string description;
        ICollection<Character> characters;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Version { get; set; }
    }
}
