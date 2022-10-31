using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Option
    {
        private static int increment = 0;
        private int id;
        private string nom;
        private decimal prix;


        public Option(string nom, decimal prix)
        {
            increment++;
            this.id = increment;
            this.nom = nom;
            this.prix = prix;
        }
        
        public decimal Prix { get => prix; }

        public void Afficher()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Option : {0}", id);
            Console.WriteLine("Nom d'Option : {0}", nom);
            Console.WriteLine("Prix d'Option : {0:0.00}", prix);
            Console.WriteLine("--------------------------");
        }


        

    }
}
