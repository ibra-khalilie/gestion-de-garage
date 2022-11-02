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
        private readonly decimal prixTaxe = 10m;


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
        public int NbPorte{ get => nbPorte; set => nbPorte = value; }
        public int NbSiege{ get => nbSiege; set => nbSiege = value; }
        public int TailleCoffre{ get => tailleCoffre; set => tailleCoffre = value; }

        public override decimal CalculerTaxe()
        {
            return this.ChevauxFiscaux * prixTaxe;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Nom de Voiture : {0} ", nom);
            Console.WriteLine("Prix Hors Taxe : {0:0.00} ", prixHT);
            Console.WriteLine("Puissance cheveaux fiscaux : {0} ", chevauxFiscaux);
            Console.WriteLine("Marque : {0} ", marque);
            Console.WriteLine("Nombre de portes : {0} ", NbPorte);
            Console.WriteLine("Nombre de siège : {0} ", NbSiege);
            Console.WriteLine("Taille du Confre : {0}m3 ", TailleCoffre);
            Console.WriteLine("Taxe du Voiture : {0:0.00} ", CalculerTaxe());
            Console.WriteLine("***************************************");
        }



    }
}
