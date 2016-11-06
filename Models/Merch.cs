using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class Merch : HasId
{
    public int Id { get; set; }
    public string bizName { get; set; }
    public string Address { get; set; }
    public int monthVolume {get; set; }
    public int numTrans {get; set; }
    public string bizType {get; set; }
    public DateTime contractExpire {get; set; }
    public int currentFees {get; set; }
    public int riskRating {get; set; }
}
public class MerchList : HasId {
    [Required]
    public int Id { get; set; }
    [Required]
    public string Summary { get; set; }
    [Required]
    public List<Merch> Merchs { get; set; }
}

public class bizCat : HasId {
    [Required]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public List<MerchList> MerchLists { get; set; }
}

// colocate DbSet declarations with classes
public partial class DB : DbContext {
    public DbSet<Merch> Merchs { get; set; }
    public DbSet<MerchList> MerchLists { get; set; }
    public DbSet<bizCat> bizCats { get; set; }
}