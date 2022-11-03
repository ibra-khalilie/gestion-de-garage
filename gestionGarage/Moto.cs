using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Moto : Vehicule
    {
        private readonly decimal prixTaxe = 0.3m;
        private int cylindre;

        public int Cylindre { get => cylindre; set => cylindre = value; }

        public Moto( string nom, decimal prixHT, Marque marque,int cylindre, string nomMoteur, int puissance, TypeMoteur type)
            : base( nom, prixHT, marque,nomMoteur,puissance,type)
        {
            this.Cylindre = cylindre;
        
        }

        public override decimal CalculerTaxe()
        {
            //Pourquoi de coversion normalement on a besoin de la somme en decimal
            return Convert.ToInt32(Cylindre * prixTaxe); ;
        }

        public override void Afficher()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Matricule du Vehicule: {0} ", Id);
            Console.WriteLine("Nom de Voiture : {0} ", Nom);
            Console.WriteLine("Prix Hors Taxe : {0:0.00} ", PrixHT);
            Console.WriteLine("Marque : {0} ", Marque);
            Console.WriteLine("Cylindre : {0} ", Cylindre);
            foreach (Moteur moteur in moteurs)
            {
                moteur.Afficher();
            }
            Console.WriteLine("Taxe du Moto : {0:0.00} ", CalculerTaxe());
            Console.WriteLine("Prix Total : {0:0.00} ", PrixTotal());
            Console.WriteLine("***************************************");
        }


    }
}
