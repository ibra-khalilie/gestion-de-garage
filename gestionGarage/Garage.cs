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
            this.nom = nom;
            vehicules = new List<Vehicule>();
        }

        public void  AjouterVehivule(Vehicule vehicule){
            vehicules.Add(vehicule);
        }
        public void Afficher() { }

        public void AfficherVoiture() { }

        public void AfficherCamion() { }

        public void AfficherMoto() {

        }

        public void TrierVehicule() { }

    }
}
