using BjApi.Models;
using Microsoft.EntityFrameworkCore;


namespace BjApi.Data {
   

    public class AppDbContext :DbContext {
       public AppDbContext(DbContextOptions<AppDbContext> opt ) :base(opt)
       {

           
       }

       public DbSet<Card> Cards {get;set;}
       public DbSet<UserScore> UserScores {get;set;}
        public DbSet<Statistic>  statistics { get; set; }

    }


}