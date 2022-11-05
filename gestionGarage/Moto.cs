using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    [Serializable]
    internal class Moto : Vehicule
    {
        private readonly decimal prixTaxe = 0.3m;
        private int cylindre;

        public Moto(string nom, decimal prixHT, Marque marque, Moteur moteur,int cylindre) : base(nom, prixHT, marque, moteur)
        {
            this.Cylindre = cylindre;
        }

        public Moto()
        {
        }

        public int Cylindre { get => cylindre; set => cylindre = value; }
     

     

        public override decimal CalculerTaxe()
        {
           
            return Convert.ToInt32(Cylindre * prixTaxe); ;
        }

        public override void Afficher()
        {
          
            Console.WriteLine(@"
                      ********************************************
                               Identifiant : {0}
                               Nom : {1} 
                               Prix Hors Taxe : {2:0.00} 
                               Marque : {3} 
                               Cylindre : {4} 
                               Taxe du Moto : {5:0.00} ",Id,Nom,prixHT,Marque,cylindre, CalculerTaxe());
                               moteur.Afficher();
                               AfficherOptions();
                               Console.WriteLine(@"
           
                                Prix Total : {0:0.00}", PrixTotal());

        }


    }
}
