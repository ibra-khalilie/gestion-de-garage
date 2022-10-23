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
        private int id;
        private string nom;
        private decimal prixHT;
        private Marque marque;

        public Vehicule(int id, string nom, decimal prixHT, Marque marque)
        {
            this.id = id;
            this.nom = nom;
            this.prixHT = prixHT;
            this.marque = marque;
        }  
       
        //les differenrs types de methodes
        public void AfficherOptions() { }

        public void Afficher() { }

        public void AjouterOption(Option Option) { }

        public decimal CalculerTaxe() { return 0; }

        public decimal PrixTotal() { return 0.0m; }


    }

}
