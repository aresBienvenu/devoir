using System;

namespace TonProjet.Models
{
    public class Fournisseur
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Adresse { get; set; }

        public bool Actif { get; set; } = true;

        public DateTime DateCreation { get; set; } = DateTime.Now;
    }
}
