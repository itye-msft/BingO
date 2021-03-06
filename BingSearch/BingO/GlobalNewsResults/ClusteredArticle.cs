﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace BingO.GlobalNewsResults
{
    public class ClusteredArticle
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "about")]
        public List<About2> About { get; set; }
        [JsonProperty(PropertyName = "provider")]
        public List<Provider2> Provider { get; set; }
        [JsonProperty(PropertyName = "datePublished")]
        public string DatePublished { get; set; }
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    }
}
