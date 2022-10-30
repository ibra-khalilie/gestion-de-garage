using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal abstract class Vehicule
    {
        private static int increment;
        protected int id;
        protected string nom;
        protected decimal prixHT;
        protected Marque marque;

        public Vehicule(string nom, decimal prixHT, Marque marque)
        {
        
            this.nom = nom;
            this.prixHT = prixHT;
            this.marque = marque;
        }  
       
        //les differenrs types de methodes
        public void AfficherOptions() { }

        public void Afficher() { }

        public void AjouterOption(Option Option) { }

        public abstract decimal CalculerTaxe();
   

        public decimal PrixTotal() { return 0.0m; }


    }

}
