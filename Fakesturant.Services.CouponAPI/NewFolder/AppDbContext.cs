using Fakesturant.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Fakesturant.Services.CouponAPI.NewFolder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Coupon> Coupons { get; set; } 
    }
}
