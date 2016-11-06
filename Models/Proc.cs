using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class Proc : HasId
{
    public int Id { get; set; }
    public string procName { get; set; }
    public string Address { get; set; }

    public string Focus {get; set; }
    
    
}

