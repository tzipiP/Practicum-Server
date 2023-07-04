using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public enum Gender
    {
        Male=1,
        Female
    }
    public enum HealthFund
    {
        Clalit=1,
        Meuchedet,
        Leumit,
        Macabi
    }
    public class UserModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdentityNumber { get; set; }

        public Gender Gender { get; set; }

        public DateTime BornDate { get; set; }


        public HealthFund HealthFund { get; set; }

        public  ICollection<ChildModel> Children { get; set; }
    }
}
