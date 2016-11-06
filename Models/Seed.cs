// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Infrastructure;


// public static class Seed
// {
//     public static void Initialize(DB db, bool isDevEnvironment)
//     {
//         if(isDevEnvironment){
//             // db.Database.EnsureDeleted(); // delete then, ...
//         }

//         db.Database.EnsureCreated(); // create the tables!!
//         db.Database.Migrate(); // ensure migrations are registered
        
//         if(db.Merchs.Any() || db.MerchLists.Any()) return;

//         bizCat b = new bizCat { Title = "Test Board", MerchLists = new List<MerchList>() };

//         Action createList = () => {
//             MerchList toReview = new MerchList { Summary="toReview items", Merchs = new List<Merch>() };

//             for(var i = 0; i < 10; i++)
//                 toReview.Merchs.Add(new Merch { bizName = $"Test Merch {i}", bizType = $"Test Content {i}",  });
            
//             b.MerchLists.Add(toReview);
//         };

//         for(var j = 0; j<3; j++)
//             createList();
        
//         db.bizCats.Add(b);
//         db.SaveChanges(); 
//         Console.WriteLine("----------Merchs SEEDED-------------");
//     }
// }