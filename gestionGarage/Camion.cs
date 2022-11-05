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

        private readonly decimal prixTaxe = 50m;


        public Camion()
        {
        }

        public Camion(string nom, decimal prixHT, Marque marque, Moteur moteur, Option option,int nbEssieu, int poid, int volume) : base(nom, prixHT, marque, moteur)
        {
            this.NbEssieu = nbEssieu;
            this.Poid = poid;
            this.Volume = volume;
        }

        public int NbEssieu { get => nbEssieu; set => nbEssieu = value; }
        public int Poid { get => poid; set => poid = value; }
        public int Volume { get => volume; set => volume = value; }



        public override decimal CalculerTaxe()
        {
            return this.NbEssieu * prixTaxe;
        }

        public override void Afficher()
        {
            
            Console.Write(@"
                        ***************************************
                                Matricule: {0}
                                Nom de Voiture : {1}
                                Prix Hors Taxe : {2:0.00}
                                Nombre de Essieux : {3}
                                Volume : {4}
                                Poid : {5}
                                Taxe du Camion : {6:0.00} 
                                Prix Total : {7:0.00} ", Id, Nom, PrixHT, NbEssieu, Volume, Poid, CalculerTaxe(), PrixTotal()
                                );
                                moteur.Afficher();
          

        }


    
    }
}
