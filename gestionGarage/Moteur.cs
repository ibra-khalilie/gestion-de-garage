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
        private static int increment;
        private int id;
        private string nom;
        private int puissance;
        private TypeMoteur type;



        public Moteur(string nom , string moteur, int puissance, TypeMoteur type)
        {
            this.nom = nom; 
            this.puissance = puissance;
            this.type = type;

        }







    }
}
