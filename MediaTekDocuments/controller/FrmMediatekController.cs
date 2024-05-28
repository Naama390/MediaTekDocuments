using MediaTekDocuments.dal;
using MediaTekDocuments.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }


        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// récèpère toutes les commandes d'un document
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns>Liste d'objets Commande</returns>

        public List<CommandeDocument> GetAllCommandes()
        {
            return access.GetAllCommandes();
        }

        /// <summary>
        /// récupère les commandes d'un document
        /// </summary>
        /// <param name="idDocument">id du document concerné</param>
        /// <returns>Liste d'objets CommandeDocument</returns>
        public List<CommandeDocument> GetCommandesDocument(string idDocument)
        {
            return access.GetCommandesDocument(idDocument);
        }

        /// </summary>
        /// <param name="id">id de la commande à insérer</param>
        /// <param name="nbExemplaire">nb d'exemplaires de la commande</param>
        /// <param name="idLivreDvd">id du document a commander</param>
        /// <param name="dateCommande">date de la commande</param>
        /// <param name="montant">montant de la commande</param>
        /// <param name="etapeSuivi">etape de suivi de la commande</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommandeDocument(string id, int nbExemplaire, string idLivreDvd, string dateCommande, int montant, string etapeSuivi)
        {
            CommandeDocument commandeDocument = new CommandeDocument(id, nbExemplaire, idLivreDvd, dateCommande, montant, etapeSuivi);
            return access.CreerCommandeDocument(commandeDocument);
        }

        /// <summary>
        /// Suppression d'une commande dans la bdd
        /// </summary>
        /// <param name="commande">L'objet Commande concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool SupprCommande(CommandeDocument commande)
        {
            return access.SupprCommande(commande);
        }

        /// <summary>
        /// Modification d'une commande dans la bdd
        /// </summary>
        /// <param name="commande">L'objet Commande concerné</param>
        /// <returns>True si la modification a pu se faire</returns>
        public bool ModifierSuivi(string id, string etapeSuivi)
        {
            return access.ModifierSuivi(id, etapeSuivi);
        }
    }
}
