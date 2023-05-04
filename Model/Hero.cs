using Microsoft.EntityFrameworkCore;

namespace APIHERO.Model
{
   
    public class Hero
    {
        public DbSet<Hero> Heroes { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        

    }
}
