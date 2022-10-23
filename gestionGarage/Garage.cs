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

        public Garage(string nom)
        {
            this.nom = nom;
        }

        public void  AjouterVehivule(Vehicule Vehicule){}
        public void Afficher() { }

        public void AfficherVoiture() { }

        public void AfficherCamion() { }

        public void AfficherMoto() { }

        public void TrierVehicule() { }

    }
}
