using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    [Serializable]
    internal class Garage
    {
        private string nom;

        private List<Vehicule> vehicules;
        private List<Moteur> moteurs = new List<Moteur>();
        private List<Option> option = new List<Option>();
        public Garage(string nom)
        {
            this.Nom = nom;
            Vehicules = new List<Vehicule>();
        }

        public void AjouterVehivule(Vehicule vehicule){
            Vehicules.Add(vehicule);
        }
        public void Afficher() {

            foreach (Vehicule vehicule in Vehicules) {
                  vehicule.Afficher();
            }
        }

        public void AfficherVoiture() {
            foreach (Vehicule vehicule in Vehicules)
            {
              if(vehicule is Voiture)
                {
                    vehicule.Afficher();
                }
            }
        }

        public void AfficherCamion() {

            foreach (Vehicule vehicule in Vehicules)
            {
                if (vehicule is Camion)
                {
                    vehicule.Afficher();
                }
            }
        }

        public void AfficherMoto() {

            foreach (Vehicule vehicule in Vehicules)
            {
                if (vehicule is Moto)
                {
                    vehicule.Afficher();
                }
            }

        }

        public void AjouterOption()
        {
            Option op = new Option();
            Console.WriteLine("Veiller entrer le nom de l'option");
            string nom = Console.ReadLine();
            op.Nom = nom;
            Console.WriteLine("Veuiller entrer le prix : ");
            decimal prix = Convert.ToDecimal(Console.ReadLine());
            op.Prix = prix;
        }
        public void AjouterMoteur()
        {
            Console.Clear();
            Moteur moteur = new Moteur();
            Console.Write(" Veuillez renseigner le nom du moteur : ");
            String nom = Console.ReadLine();
            moteur.Nom = nom;

            
            Console.Write(" Puissance du moteur : ");
            int puissance = Convert.ToInt32(Console.ReadLine());
            moteur.Puissance = puissance;
   


            Console.WriteLine("Veuiller choix la marque de votre choix : ");
            TypeMoteur choixMarque = new Menu().ChoisirTypeMoteur();
            moteur.Type = choixMarque;
            
            Moteurs.Add(moteur);
            Console.WriteLine(@"
                                 ----------------------
                                     - Succées !-
                                - Moteur bien ajouté - ");

        }


  
        public void TrierVehicule() {
            Vehicules.Sort();
        }


        public string Nom { get => nom; set => nom = value; }
        public List<Vehicule> Vehicules { 
            get => vehicules;
            set => vehicules = value; }
        public List<Moteur> Moteurs { get => moteurs; set => moteurs = value; }
        public List<Option> Option { get => option; set => option= value; }
    }


}
