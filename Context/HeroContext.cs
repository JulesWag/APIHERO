using APIHERO.Model;
using Microsoft.EntityFrameworkCore;




namespace APIHERO.Context
{
    public class HeroContext : DbContext
    {

       public HeroContext() 
        {
        
        }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3IJUO7C;Initial Catalog=Cours;Integrated Security=True;Encrypt=false");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        //entité
        public DbSet<Hero> Name { get; set; }
        public DbSet<Power> Powers { get; set; }
        

        public DbSet<School> School { get; set; } = default!;
    }
}
