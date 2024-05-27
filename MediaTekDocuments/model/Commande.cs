using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Commande
    /// </summary>
    public class Commande
    {
        public string Id { get; set; }
        public string DateCommande { get; set; }
        public int Montant { get; set; }

        public Commande(string id, string dateCommande, int montant)
        {
            Id = id;
            DateCommande = dateCommande;
            Montant = montant;
        }
    }
}
