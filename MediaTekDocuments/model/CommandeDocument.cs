using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeDocument : hérite de Commande
    /// </summary>
    public class CommandeDocument : Commande
    {
        public int NbExemplaire { get; set; }
        public string IdLivreDvd { get; set; }
        public string EtapeSuivi { get; set; }

        public CommandeDocument(string id, int nbExemplaire, string idLivreDvd, string dateCommande, int montant, string etapeSuivi) : base(id, dateCommande, montant)
            {
            this.NbExemplaire = nbExemplaire;
            this.IdLivreDvd = idLivreDvd;
            this.EtapeSuivi = etapeSuivi;
        }
    }
}
