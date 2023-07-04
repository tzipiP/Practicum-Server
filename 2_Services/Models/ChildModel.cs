using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ChildModel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BornDate { get; set; }

        public string IdentityNumber { get; set; }
        public int FatherId { get; set; }

        //public virtual UserModel Father { get; set; } = null!;
    }
}
