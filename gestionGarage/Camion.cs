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

        private readonly int prixTaxe = 50;

        public Camion(string nom, decimal prixHT, Marque marque, string nomMoteur, int puissance, TypeMoteur type, int nbEssieu, int poid, int volume) :
            base(nom, prixHT, marque,nomMoteur,puissance,type)
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
            Console.WriteLine("***************************************");
            Console.WriteLine("Matricule du Vehicule: {0} ", Id);
            Console.WriteLine("Nom de Voiture : {0} ", Nom);
            Console.WriteLine("Prix Hors Taxe : {0:0.00} ", PrixHT);
            Console.WriteLine("Moeur : {0} ", Moteur);
            Console.WriteLine("Nombre de Essieux : {0} ", NbEssieu);
            Console.WriteLine("Marque : {0} ", Marque);
            Console.WriteLine("Volume : {0} ", Volume);
            Console.WriteLine("Poid : {0} ", Poid);
            foreach (Moteur moteur in moteurs)
            {
                moteur.Afficher();
            }
            Console.WriteLine("Taxe du Camion : {0:0.00} ", CalculerTaxe());
            Console.WriteLine("Prix Total : {0:0.00} ", PrixTotal());
            Console.WriteLine("***************************************");
        }
    }
}
