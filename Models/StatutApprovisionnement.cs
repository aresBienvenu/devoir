namespace TonProjet.Models
{
    /// <summary>
    /// Statut d'un approvisionnement.
    /// Valeurs par défaut : stockées en base comme entiers (0,1,2).
    /// Si tu préfères stocker les noms ("EnAttente", ...) en base, je te montrerai la conversion EF Core.
    /// </summary>
    public enum StatutApprovisionnement
    {
        EnAttente = 0,
        Recu = 1,
        Annule = 2
    }
}
