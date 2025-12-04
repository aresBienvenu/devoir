using Microsoft.EntityFrameworkCore;
using TonProjet.Models;

namespace TonProjet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // TABLES
        // public DbSet<StatutApprovisionnement> StatutsApprovisionnement { get; set; }
        public DbSet<Approvisionnement> Approvisionnements { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        // public DbSet<Produit> Produits { get; set; }
        // public DbSet<Categorie> Categories { get; set; }
    }
}
