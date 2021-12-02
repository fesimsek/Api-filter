using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Il : BaseEntity
    {
        //public int ID { get; set; }
        
        public string Ad { get; set; }
        public string Bolge { get; set; }
        public int No { get; set; }
        public int? Numara { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DateNull { get; set; }
        
    }
}
