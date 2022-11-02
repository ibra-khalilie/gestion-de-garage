using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Garage
    {
        private string nom;

        private List<Vehicule> vehicules;
    
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

        public void TrierVehicule() {
            Vehicules.Sort();
        }


        public string Nom { get => nom; set => nom = value; }
        public List<Vehicule> Vehicules { 
            get => vehicules;
            set => vehicules = value; }
    }


}
