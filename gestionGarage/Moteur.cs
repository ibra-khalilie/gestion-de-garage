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
   


        public Moteur()
        {
            increment++;
    
        }
        public Moteur(string nom , int puissance, TypeMoteur type)
        {
            increment++;
            this.id = increment;
            this.Nom = nom; 
            this.Puissance = puissance;
            this.Type = type;

        }

        public string Nom { get => nom; set => nom = value; }
        public int Puissance { get => puissance; set => puissance = value; }
        public int Id { get => id; }
        internal TypeMoteur Type { get => type; set => type = value; }

        public void Afficher()
        {



             Console.WriteLine(@" 
                                   m-o-t-e-u-r
                                Numero du moteur : {0}
                                Nom du moteur : {1}
                                Puissance : {2}
                                Type de motteur : {3}",id,Nom,Puissance,Type);
        }

    }
}
