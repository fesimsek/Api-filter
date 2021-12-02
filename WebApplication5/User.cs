using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class User : BaseEntity
    {

        public int? User_ID { get; set; }
        public int Customer_ID { get; set; }

        

        public int User_Name { get; set; }
        public int Birim { get; set; }
        
        public int ParentUserId { get; set; }
        public virtual User Parent { get; set; }
        public virtual HashSet<User> Children { get; set; }


        public ICollection<Il> Ils{ get; set; }
        



    }
}
