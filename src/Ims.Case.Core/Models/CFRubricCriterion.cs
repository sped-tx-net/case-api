﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ims.Case.Models
{
    public class CFRubricCriterion
    {
        public CFRubricCriterion()
        {
            CFRubricCriterionLevels = new List<CFRubricCriterionLevel>();
        }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("CFItemURI")]
        public LinkURI CFItemURI { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("rubricId")]
        public string RubricId { get; set; }

        [JsonProperty("lastChangeDateTime")]
        public DateTime LastChangeDateTime { get; set; }

        [JsonProperty("CFRubricCriterionLevels")]
        public List<CFRubricCriterionLevel> CFRubricCriterionLevels { get; set; }

    }

}
