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
   

        public Moteur(string nom , int puissance, TypeMoteur type)
        {
            increment++;
            this.id = increment;
            this.nom = nom; 
            this.puissance = puissance;
            this.type = type;

        }

        public void Afficher()
        {


            Console.WriteLine(@"
            Numero du moteur : {0}
            Nom du moteur : {0}
            Puissance : {0}
            Type de motteur : {0}",id,nom,puissance, type
           );
        }

    }
}
