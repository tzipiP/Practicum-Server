using System;
using System.Collections.Generic;

namespace PracticumServer.Models;

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

public  class User
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string IdentityNumber { get; set; }

    public Gender Gender { get; set; }

    public DateTime BornDate { get; set; }


    public HealthFund HealthFund { get; set; }

    public ICollection<Child> Children { get; set; } = new List<Child>();
    //public List<Child> Children { get; set; } 

}
