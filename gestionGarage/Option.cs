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
            this.Id = increment;
            this.Nom = nom;
            this.Prix = prix;
        }
        
        public int Id { get => id; set => id = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public string Nom { get => nom; set => nom = value; }
       

        public void Afficher()
        {
            Console.WriteLine("\nNumero d'Option : {0}", Id);
            Console.WriteLine("Nom d'Option : {0}", Nom);
            Console.WriteLine("Prix d'Option : {0:0.00}\ns", Prix);
        }


        

    }
}
