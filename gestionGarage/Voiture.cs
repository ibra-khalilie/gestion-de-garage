using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Voiture : Vehicule
    {

        private int chevauxFiscaux;
        private int nbPorte;
        private int tailleCoffre;
        private int nbSiege;
        private readonly decimal prixTaxe = 10m;

        public Voiture()
        {
            
        }

        public Voiture(string nom, decimal prixHT, Marque marque, Moteur moteur, int tailleCofre, int cheveauxFiscaux, int nbSiege, int nbPorte) : base(nom, prixHT, marque, moteur)
        {
            this.TailleCoffre = tailleCofre;
            this.NbSiege = nbSiege;
            this.NbPorte = nbPorte;
            this.chevauxFiscaux = cheveauxFiscaux;
        

        }


        public int NbPorte
        {
            get => nbPorte;
            set
            {
                //On considere que une voiture ne peut avoir moins deux porte et plus 2 porte
                nbPorte = SetGetControl(value, 2, 6);

            }
        }

        public int NbSiege
        {
            get => nbSiege;
            set
            {
                //Pareil
                nbSiege = SetGetControl(value, 2, 50);
            }
        }
        public int TailleCoffre
        {
            get => tailleCoffre;
            set
            {
                tailleCoffre = SetGetControl(value, 100, 600);
            }
        }





        //modificateurs d'accèes 
        public int ChevauxFiscaux{ get => chevauxFiscaux; set => chevauxFiscaux = value; }
   

        public override decimal CalculerTaxe()
        {
            return this.ChevauxFiscaux * prixTaxe;
        }

        public override void Afficher()
        {



            //  Console.BackgroundColor = ConsoleColor.DarkBlue;
         
            Console.WriteLine(@"
                     ********************************************
                               Indentifiant : {0}                  
                               Nom de Voiture : {1}                
                               Prix Hors Taxe : {2:0.00}           
                               Marque : {3}                        
                               Nombre de portes : {4}              
                               Taille du Confre : {6}m3            
                               ", Id, Nom, PrixHT, Marque, nbPorte, nbSiege, TailleCoffre);
                         
                                moteur.Afficher();
                                AfficherOptions();

                               Console.WriteLine(@"
                                Taxe : {0:0.00} 
                                Prix Total : {1:0.00}",CalculerTaxe(), PrixTotal());





        }


        public string Nom { get => base.Nom; set => base.Nom = value; }
    
    }
}
