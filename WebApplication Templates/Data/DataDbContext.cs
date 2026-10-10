using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_Templates.Models;

namespace WebApplication_Templates.Data
{
    public class DataDbContext : IdentityDbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> op):base(op)
        {

        }
        public DbSet<SystemSettings> SystemSettings { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Titles> Titles { get; set; }
        public DbSet<TransactionReservation> TransactionReservation { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<MasterSocialMedia> MasterSocialMedia { get; set; }
        public DbSet<MasterContactUs> MasterContactUs { get; set; }
        public DbSet<OpeningTime> OpeningTime { get; set; }
        public DbSet<TransactionNewsLetter> TransactionNewsLetter { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<MenuCategory> MenuCategory { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<MasterTransactionContactUs> MasterTransactionContactUs { get; set; }


    }
}
