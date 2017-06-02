using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace TableauDeBord
{
    class Passerelle
    {
        static string chaineConnexion = "Data Source=win-921c8fktgae;Initial Catalog=tableaudebord;User ID=vanbaelinghem;Password=vanbaelinghem";
        static SqlConnection taConnexion;

        public static SqlConnection Connection() // Connexion bdd 
        {
            //SqlConnection taConnexion;
            taConnexion = new SqlConnection(chaineConnexion);
            return taConnexion;
        }
        
        public static Boolean utilisateur(string login, string mdp)
        {
            SqlConnection taConnexion = Connection();
            taConnexion.Open();

            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT * FROM Connexion WHERE Login = '" + login + "'"; // recupere les informations de l'identifiant
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            Boolean i = false;
            while (Resultat.Read()) //Parcours le resultat
            {
                string mdpasse = (string)Resultat["MotDePasse"];
                if (mdp == mdpasse)    //Test l'égalité
                {
                    i = true;
                }
            }
            return i;
        }

        public static int[] coutTotalMedoc(int pAnnee)
        {
            int[] pointsArray = new int[12];
            Connection();
            taConnexion.Open();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT Mois, prixTotal FROM CoutTotal WHERE Annee=" + pAnnee; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int Mois = (int)Resultat["Mois"];
                int prixTotal = (int)Resultat["prixTotal"];
                pointsArray[Mois - 1] = prixTotal;
                
            }
            return pointsArray;
        }
        public static int[] nbLitAnnee(int pAnnee)
        {
            int[] pointsArray = new int[12];

            //// Requete
            //string chaineConnexion = "Data Source=win-921c8fktgae;Initial Catalog=tableaudebord;User ID=vanbaelinghem;Password=vanbaelinghem";
            //SqlConnection laConnexion;
            //laConnexion = new SqlConnection(chaineConnexion);
            Connection();
            taConnexion.Open();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT Mois, NbLitsOccup FROM Occupation WHERE Annee=" + pAnnee; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int Mois = (int)Resultat["Mois"];
                int nbLitsOccup = (int)Resultat["NbLitsOccup"];
                pointsArray[Mois - 1] = nbLitsOccup;
                // MessageBox.Show("moi " + Mois+" nbLits "+nbLitsOccup);
            }
            return pointsArray;
        }

        public static int[] dureeMoy(int pAnnee)
        {
            int[] pointsArray = new int[12];
            Connection();
            taConnexion.Open();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT Mois, dureeMoy FROM dureeMoy WHERE Annee=" + pAnnee; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int Mois = (int)Resultat["Mois"];
                int dureeMoy = (int)Resultat["dureeMoy"];
                pointsArray[Mois - 1] = dureeMoy;
                // MessageBox.Show("moi " + Mois+" nbLits "+nbLitsOccup);
            }
            return pointsArray;
        }
        public static double pourcentage()
        {
            SqlConnection taConnexion = Connection();
            taConnexion.Open();

            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT nbeLitsOccupes FROM Occupation"; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, taConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            double calcul = 0;
            while (Resultat.Read()) //Parcours le resultat
            {
                string Mois = (string)Resultat["Mois"];                
                int nbLitsOccup = (int)Resultat["nbeLitsOccupes"];
                calcul = 100 * (nbLitsOccup);
            }

            return calcul;            
        }       
        
    }
}
