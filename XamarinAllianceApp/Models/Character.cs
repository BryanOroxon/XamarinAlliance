using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XamarinAllianceApp.Models
{
    public class Character
    {
        Int32 id;
        string name;
        string biography;
        string gender;
        float height;
        string databankUrl;
        string imageUrl;
        ICollection<Weapon> weapons;
        ICollection<Movie> appearances;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "gender")]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [JsonProperty(PropertyName = "biography")]
        public string Biography
        {
            get { return biography; }
            set { biography = value; }
        }

        [JsonProperty(PropertyName = "height")]
        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        [JsonProperty(PropertyName = "databankUrl")]
        public string DatabankUrl
        {
            get { return databankUrl; }
            set { databankUrl = value; }
        }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        [JsonProperty(PropertyName = "weapons")]
        public ICollection<Weapon> Weapons
        {
            get { return weapons; }
            set { weapons = value; }
        }

        [JsonProperty(PropertyName = "appearances")]
        public ICollection<Movie> Appearances
        {
            get { return appearances; }
            set { appearances = value; }
        }

        public string Version { get; set; }
    }
}
