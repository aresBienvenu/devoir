using System;

namespace TonProjet.Models
{
    public class LigneApprovisionnement
    {
        public int Id { get; set; }

        // Clé étrangère vers Approvisionnement
        public int ApprovisionnementId { get; set; }
        public Approvisionnement Approvisionnement { get; set; }

        // Clé étrangère vers Article
        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int Quantite { get; set; }

        public decimal PrixUnitaire { get; set; }

        public decimal Montant { get; set; }

        /// <summary>
        /// Calcul automatique du montant (Quantite * PrixUnitaire)
        /// </summary>
        public decimal CalculerMontant()
        {
            return Quantite * PrixUnitaire;
        }
    }
}
