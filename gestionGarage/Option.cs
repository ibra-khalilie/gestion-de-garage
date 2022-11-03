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

      
        public Option() { }
        public Option(string nom, decimal prix)
        {
            increment++;
            this.Id = increment;
            this.Nom = nom;
            this.prix = prix;
        }
        
      
        public string Nom { get => nom; set => nom = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public int Id { get => id; set => id = value; }

        public void Afficher()
        {
            

            Console.WriteLine("Oprion : "+ id);
            Console.WriteLine("Nom : "+nom);
            Console.WriteLine("Prix : "+prix);

        }


        

    }
}
