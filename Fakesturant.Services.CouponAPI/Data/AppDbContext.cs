using Fakesturant.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Fakesturant.Services.CouponAPI.NewFolder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "TENNY",
                DiscountAmount = 10,
                MinAmount = 25
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "LBRDAY",
                DiscountAmount = 15,
                MinAmount = 30
            });
        }
    }
}
