using System;
using System.Collections.Generic;

namespace TonProjet.Models
{
    public class Approvisionnement
    {
        public int Id { get; set; }

        public string Reference { get; set; }

        public DateTime DateApprovisionnement { get; set; } = DateTime.Now;

        // Clé étrangère vers Fournisseur
        public int FournisseurId { get; set; }
        public Fournisseur Fournisseur { get; set; }

        public string Observations { get; set; }

        public decimal MontantTotal { get; set; }

        public StatutApprovisionnement Statut { get; set; } = StatutApprovisionnement.EnAttente;

        public DateTime DateCreation { get; set; } = DateTime.Now;

        public DateTime? DateModification { get; set; }

        // Collection des lignes
        public List<LigneApprovisionnement> Lignes { get; set; } = new List<LigneApprovisionnement>();

        /// <summary>
        /// Calcule le montant total en additionnant les montants de chaque ligne.
        /// </summary>
        public decimal CalculerMontantTotal()
        {
            decimal total = 0;

            foreach (var ligne in Lignes)
            {
                total += ligne.CalculerMontant();
            }

            return total;
        }
    }
}
