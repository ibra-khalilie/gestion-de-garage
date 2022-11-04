using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Voiture : Vehicule
    {

        private int chevauxFiscaux;
        private int nbPorte;
        private int tailleCoffre;
        private int nbSiege;
        //private static new int id = 1 ;
        private readonly int prixTaxe = 10;

       

        public Voiture(string nom, decimal prixHT,Marque marque,string nomMoteur,int puissance, TypeMoteur type,int tailleCofre, int cheveauxFiscaux, int nbSiege, int nbPorte) : 
            base(nom, prixHT, marque,nomMoteur,puissance,type)
        {
                this.TailleCoffre = tailleCofre;
                this.NbSiege = nbSiege;
                this.NbPorte = nbPorte;
                this.chevauxFiscaux = cheveauxFiscaux;
       
        }

     



        //modificateurs d'accèes 
        public int ChevauxFiscaux{ get => chevauxFiscaux; set => chevauxFiscaux = value; }
        public int NbPorte
        { 
            get => nbPorte;
            set
            {
                //On considere que une voiture ne peut avoir moins deux porte et plus 2 porte
                nbPorte = SetGetControl(value,2,6);

            }
        }

        public int NbSiege
        { 
            get => nbSiege;
            set
            {
                //Pareil
                nbSiege = SetGetControl(value, 2, 50);
            } 
        }
        public int TailleCoffre
        {  
            get => tailleCoffre;
            set
            {
                tailleCoffre = SetGetControl(value, 100, 600);
            } 
        }

        public override decimal CalculerTaxe()
        {
            return this.chevauxFiscaux * prixTaxe;
        }

        public override void Afficher()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Matricule du Vehicule: {0} ", Id);
            Console.WriteLine("Nom de Voiture : {0} ", Nom);
            Console.WriteLine("Prix Hors Taxe : {0:0.00} ", PrixHT);
            Console.WriteLine("Puissance cheveaux fiscaux : {0} ", ChevauxFiscaux);
            Console.WriteLine("Marque : {0} ", Marque);
            Console.WriteLine("Nombre de portes : {0} ", NbPorte);
            Console.WriteLine("Nombre de siège : {0} ", NbSiege);
            Console.WriteLine("Taille du Confre : {0}m3 ", TailleCoffre);
            foreach (Moteur moteur in moteurs)
            {
                moteur.Afficher();
            }
            AfficherOptions();
            Console.WriteLine("Taxe : {0:0.00} ", CalculerTaxe());
            Console.WriteLine("Prix Total : {0:0.00} ", PrixTotal());
            Console.WriteLine("***************************************");
        }




    }
}
