using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Filter 
    {
        //[Key]
        //[JsonProperty("logic")]
        //public string Logic { get; set; }

        //[JsonProperty("filters")]
        //public ICollection<Filter> Filters { get; set; }

        //[JsonProperty("field")]
        //public string Field { get; set; }

        //[JsonProperty("operator")]
        //public string Operator { get; set; }

        //[JsonProperty("value")]
        //public string Value { get; set; }
        [Key]
        public string Field { get; set; }
        public string Operator { get; set; }
        [NotMapped]
        public dynamic Value { get; set; }





    }

}
