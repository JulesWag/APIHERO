using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APIHERO.Model
{
   
    public class Hero
    {
        
        public int Id { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        


    }
}
