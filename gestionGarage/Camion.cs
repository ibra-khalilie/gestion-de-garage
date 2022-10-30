using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Camion : Vehicule
    {

        private int nbEssieu;
        private int poid;
        private int volume;
        private static new int id;

        private readonly int prixTaxe = 50;

        public Camion(int id, string nom, decimal prixHT, Marque marque, int nbEssieu, int poid, int volume) :
            base(nom, prixHT, marque)
        {
            this.NbEssieu = nbEssieu;
            this.Poid = poid;
            this.Volume = volume;
            id++;
         }

    

        public override decimal CalculerTaxe()
        {
            return this.NbEssieu * prixTaxe;
        }



        public int NbEssieu { get => nbEssieu; set => nbEssieu = value; }
        public int Poid { get => poid; set => poid = value; }
        public int Volume { get => volume; set => volume = value; }
    }
}
