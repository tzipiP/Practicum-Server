using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticumServer.Models;

public  class Child
{

    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime BornDate { get; set; }

    public string IdentityNumber { get; set; }

    [ForeignKey("Father")]
    public int FatherId { get; set; }

   public  User Father { get; set; } = null!;
}
