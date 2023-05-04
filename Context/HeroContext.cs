using APIHERO.Model;
using Microsoft.EntityFrameworkCore;


namespace APIHERO.Context
{
    public class HeroContext : DbContext
    {

        public DbSet<Hero> Heroes { get; set; }

    }
}
