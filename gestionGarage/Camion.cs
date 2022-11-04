using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Console.WriteLine("@***************************************",
                                "Matricule du Vehicule: {0} ", 
                                "Nom de Voiture : {1} ",
                                "Prix Hors Taxe : {2:0.00}",
                                "Moeur : {3} ",
                                "Nombre de Essieux : {4} ",
                                "Volume : {5} ", 
                                "Poid : {6} ", 
                                "Taxe du Camion : {7:0.00} ", 
                                "Prix Total : {8:0.00} ",Id,Nom,PrixHT,Moteur,NbEssieu,Volume,Poid,CalculerTaxe(),PrixTotal()
                                );

            foreach (Moteur moteur in moteurs)
            {
                moteur.Afficher();
            }
            Console.WriteLine("***************************************");
        }
    }
}
