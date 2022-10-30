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
        private static new int id = 1 ;
        private readonly int prixTaxe = 10;
        public Voiture(string nom, decimal prixHT, Marque marque,int tailleCofrfre, int nbSiege, int nbPorte) : 
            base(nom, prixHT, marque)
        {
                this.TailleCoffre = tailleCofrfre;
                this.NbSiege = nbSiege;
                this.NbPorte = nbPorte;
                id++;

        }


        public override decimal CalculerTaxe()
        {
            return this.chevauxFiscaux * prixTaxe;
        }

        public override string ToString()
        {
            return "Nom : " + nom + "\n" +
                   "Prix Hors Taxe :" + marque + "\n" +
                   "Indentifiant Voiture :" + id + "\n" +
                   "Puissance cheveaux fiscaux : " + chevauxFiscaux + "\n" +
                   "Nombre de portes : " + NbPorte + "\n" +
                   "Nombre de siège : " + NbSiege + "\n";
        }




        //modificateurs d'accèes 
        public int ChevauxFiscaux
        {
            get => chevauxFiscaux;
            set => chevauxFiscaux = value;
        }


        public int NbPorte
        {
            get => nbPorte;
            set => nbPorte = value;
        }


        public int NbSiege
        {
            get => nbSiege;
            set => nbSiege = value;
        }

        public int TailleCoffre
        {
            get => tailleCoffre;
            set => tailleCoffre = value;
        }


    }
}
