using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OOTPiSP__2
{
    class OrderContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Glider> Gliders { get; set; }
        public DbSet<Helicopter> Helicopters { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Order> Orders { get; set; }

        public OrderContext()
            : base("DbConnection")
        { }
    }
}
