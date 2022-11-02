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
           
            return Convert.ToInt32(Cylindre * prixTaxe); ;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Nom de Voiture : {0} ", nom);
            Console.WriteLine("Prix Hors Taxe : {0:0.00} ", prixHT);
            Console.WriteLine("Marque : {0} ", marque);
            Console.WriteLine("Cylindre : {0} ", Cylindre);
            Console.WriteLine("Taxe du Moto : {0:0.00} ", CalculerTaxe());
            Console.WriteLine("***************************************");
        }


    }
}
