using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Moteur
    {
        private static int increment=0;
        private int id;
        private string nom;
        private int puissance;
        private TypeMoteur type;


        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Puissance { get => puissance; set => puissance = value; }
        public TypeMoteur Type { get => type; set => type = value; }


        public Moteur(string nom , int puissance, TypeMoteur type)
        {
            increment++;
            this.Id = increment;
            this.Nom = nom; 
            this.Puissance = puissance;
            this.Type = type;

        }

        public void Afficher()
        {

            Console.WriteLine("\nNumero du moteur : {0}", Id);
            Console.WriteLine("Nom du moteur : {0}", Nom);
            Console.WriteLine("Puissance : {0}", Puissance);
            Console.WriteLine("Type de motteur : {0}\n", Type);
        }

    }
}
