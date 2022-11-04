using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal abstract class Vehicule : IComparable
    {
        private static int increment = 0;
        protected int id;
        protected string nom;
        protected decimal prixHT;

      
       
        protected Marque marque;
        protected Moteur moteur;

     

        protected List<Option> options = new List<Option>();
        protected List<Moteur> moteurs = new List<Moteur>();
        public Vehicule(string nom, decimal prixHT, Marque marque,string nomMoteur, int puissance, TypeMoteur type)
        {
            increment++;
            this.Id = increment;
            this.Nom = nom;
            this.PrixHT = prixHT;
            this.marque = marque;

            //A discuter
            moteur = new Moteur(nomMoteur,puissance, type);
            moteurs.Add(moteur);
            
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal PrixHT { get => prixHT; set => prixHT = value; }
        public Marque Marque { get => marque; set => marque = value; }
        public Moteur Moteur { get => moteur; set => moteur = value; }



        //les differenrs types de methodes
        public void AfficherOptions() {
            foreach (Option option in options)
            {
                option.Afficher();
            }
                
        }

        public abstract void Afficher();

        public void AjouterOption(Option option) {
            options.Add(option);
        }

        public abstract decimal CalculerTaxe();
   

        public decimal PrixTotal() {

            decimal TotalOption = 0 ;
            foreach (Option option in options)
            {
                TotalOption += option.Prix;
            }
            
            return TotalOption + CalculerTaxe() + PrixHT;
        }

        public int CompareTo(object obj)
        {

            if (obj == null) return 1;

            Vehicule vehicule = obj as Vehicule;
            if (vehicule != null)
                //A voir verfier le calcul du prix pour une meilleur comparaison
                return  this.PrixTotal().CompareTo(vehicule.PrixTotal());
            else
                throw new ArgumentException("l'objet n'est pas un vehicule");
        }

        public int SetGetControl(int val,int min , int max)
        {
            int value = val;

            while(value < min || value > max)
            {
                Console.WriteLine("Erreur : entre {0} et {1} ", min, max);
                value = Convert.ToInt32(Console.ReadLine());

            }

            return value;
        }




    }

}
