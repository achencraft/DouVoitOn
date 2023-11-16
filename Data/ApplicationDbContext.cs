using Microsoft.EntityFrameworkCore;
using DouVoitOn.Models;

namespace DouVoitOn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<Lieu> Lieux { get; set; }
        public DbSet<LieuPanneau> LieuPanneau { get; set; }
        public DbSet<Panneau> Panneaux { get; set; }
        public DbSet<DouVoitOn.Models.Route> Routes { get; set; }
        public DbSet<RoutePanneau> RoutePanneau { get; set; }
        public DbSet<TypeAction> TypesAction { get; set; }
        public DbSet<TypePanneau> TypesPanneau { get; set; }
        public DbSet<User> Users { get; set; }
    }
}