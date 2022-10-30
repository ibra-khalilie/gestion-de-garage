using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Moto : Vehicule
    {
        private readonly decimal prixTaxe = 0.3m;
        private static new int id;
        private int cylindre;

        public int Cylindre { get => cylindre; set => cylindre = value; }

        public Moto( string nom, decimal prixHT, Marque marque,int cylindre)
            : base( nom, prixHT, marque)
        {
            this.Cylindre = cylindre;
            id++;
        }

        public override decimal CalculerTaxe()
        {
            throw new NotImplementedException();
        }

   

    }
}
