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
        public int Cylindre1 { get => cylindre; set => cylindre = value; }

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
          
            Console.WriteLine(@"
            Identifiant du vehicule : {
            Nom : {0} 
            Prix Hors Taxe : {0:0.00} 
            Marque : {0} 
            Cylindre : {0} 
            Taxe du Moto : {0:0.00} ",Nom,prixHT,marque,cylindre, CalculerTaxe());
            base.Afficher();

        }


    }
}
