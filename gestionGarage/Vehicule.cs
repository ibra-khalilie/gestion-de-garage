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
            this.id = increment;
            this.nom = nom;
            this.prixHT = prixHT;
            this.marque = marque;

            //A discuter
            moteur = new Moteur(nomMoteur,puissance, type);
            moteurs.Add(moteur);
            
        }  
       
        //les differenrs types de methodes
        public void AfficherOptions() {
            foreach (Option option in options)
            {
                option.Afficher();
            }
                
        }

        public virtual void Afficher() {

            Console.WriteLine("***************************************");
            Console.WriteLine("Vehicule: {0} ", id);
            AfficherOptions();
            foreach (Moteur moteur in moteurs)
            {
                moteur.Afficher();
            }

           
        }

        public void AjouterOption(Option option) {
            options.Add(option);
        }

        public abstract decimal CalculerTaxe();
   

        public decimal PrixTotal() {

            decimal resultat = 0.00m ;
            foreach (Option option in options)
            {
                resultat = option.Prix + prixHT ;
            }
            



            return resultat;
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
    }

}
