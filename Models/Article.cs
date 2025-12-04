using System;

namespace TonProjet.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public string Reference { get; set; }

        public decimal PrixUnitaire { get; set; }

        public string Unite { get; set; }

        public int StockActuel { get; set; } = 0;

        public bool Actif { get; set; } = true;

        public DateTime DateCreation { get; set; } = DateTime.Now;
    }
}
