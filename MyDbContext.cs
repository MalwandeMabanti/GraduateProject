using Microsoft.EntityFrameworkCore;
using NewProject.Models;

namespace NewProject

{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileViewModel>().ToTable("Profiles");
        }

        public DbSet<ProfileViewModel> Profile { get; set; }

        /*public DbSet<ProfileViewModel> profileViewModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GraduateDatabase;");
        }*/


    }
}
