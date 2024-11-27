using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2024_Labo
{
    /// <summary>
    /// La classe assistant contrôle le logiciel
    /// Elle est en charge d'interagir avec l'utilisateur pour enregistrer ses demandes
    /// 
    /// Le constructeur commence par mettre en mémoire les prix dans le fichier des données(transmis en paramètre)
    /// 
    /// Ensuite la méthode Magasiner() prend en charge les interactions avec l'utilsateur
    /// il a le choix de :
    /// 1. ajouter un item
    /// 2. visualiser le panier
    /// 3. terminer
    /// 
    /// Lorsque l'utilisateur choisi de terminer l'utilisation du logiciel le panier est envoyé dans un fichier
    /// texte au même format que l'affichage
    /// </summary>
    public class Assistant
    {
        List<Item> donneesMagasins;
        Panier panier;

        /// <summary>
        /// Le constructeur 
        /// - initialise les attributs
        /// - lit le fichier de données et convertit les informations en items
        /// - ajoute les items dans la liste donneesMagasin
        /// </summary>
        /// <param name="cheminFichier">Le chemin complet pour le fichier des données de prix</param>
        public Assistant(string cheminFichier)
        { 
            
        }
        /// <summary>
        /// Affiche le menu principal à l'utilisateur
        /// Récupère le choix de l'utilisateur et appelle la méthode correspondante
        /// Ajouter un produit : méthode AjouterItem
        /// Voir le panier : méthode AfficherPanier
        /// Terminer : méthode Terminer
        /// </summary>
        public void Magasiner()
        {
            
        }

        /// <summary>
        /// Affiche le menu pour ajouter un produit
        /// Demande à l'utilisateur le produit à ajouter et la quantité désirée
        /// Trouve l'item correspondant avec le prix le plus bas dans la liste donneesMagasins
        /// Envoie l'item trouvé et la quantité à la méthode AjouterItem de this.panier
        /// </summary>
        public void AjouterItem()
        {
            
        }

        /// <summary>
        /// Affiche le panier à la console en regroupant les produits par magasin
        /// </summary>
        public void AfficherPanier()
        {
            
        }

        /// <summary>
        /// Génére un fichier nommé : ListeAssistant.txt
        /// Ce fichier contient le même résumé que le résumé affiché par AfficherPanier
        /// On ajoute le total du panier à la fin du résumé
        /// </summary>
        public void Terminer()
        {
            
        }
    }
}
