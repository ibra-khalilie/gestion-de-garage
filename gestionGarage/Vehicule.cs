using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    [Serializable]
    internal abstract class Vehicule : IComparable
    {
        private static int increment = 0;
        private int id;
        private string nom;
        protected decimal prixHT;
        protected Marque marque;
        protected Moteur moteur;
        protected List<Option> options = new List<Option>();

       public Vehicule()
        {
            increment++;
            this.Id = increment;
        }


        


        public Vehicule(string nom, decimal prixHT, Marque marque, Moteur moteur)
        {
            increment++;
            this.Id = increment;
            this.Nom = nom;
            this.prixHT = prixHT;
            this.Marque = marque;
            this.Moteur = moteur;
     

            
        }  
       
        //les differenrs types de methodes
        public void AfficherOptions() {
            foreach (Option option in options)
            {
                option.Afficher();
            }
                
        }

        public virtual void Afficher() {

           // Console.WriteLine(@"
           // Identifiant du vehicule : {0} ", id);
       
            
                moteur.Afficher();
        
            AfficherOptions();


        }

        public void AjouterOption(Option option) {
            options.Add(option);
        }

        public abstract decimal CalculerTaxe();


        public decimal PrixTotal()
        {

            decimal TotalOption = 0;
            foreach (Option option in options)
            {
                TotalOption += option.Prix;
            }

            return TotalOption + CalculerTaxe() + PrixHT;
        }


        public int SetGetControl(int val, int min, int max)
        {
            int value = val;

            while (value < min || value > max)
            {
                Console.WriteLine("Entrer une valeur comprise entre {0} et {1} ", min, max);
                value = Convert.ToInt32(Console.ReadLine());

            }

            return value;
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

        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set => id = value; }
        public decimal PrixHT { get => prixHT; set => prixHT = value; }
        public List<Option> Options { get => options; set => options = value; }
     
     
        public Marque Marque { get => marque; set => marque = value; }
        public Moteur Moteur { get => moteur; set => moteur = value; }
    }



}
