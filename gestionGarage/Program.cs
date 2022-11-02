using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
             new Menu(new Garage("Go"));

            /*
            Option o1 = new Option("bbb", 200);
            Option o2 = new Option("PP", 400);
            Option o3 = new Option("Ff", 500);
            Option o4 = new Option("dd", 500);
            Option o5 = new Option("tt", 500);
            Voiture v = new Voiture("voiture1",200,Marque.peugot, "moteur1", 2000,TypeMoteur.electrique,20,100,6,5);
            v.AjouterOption(o1);
            v.AjouterOption(o2);
            v.PrixTotal();
            v.Afficher();

            Vehicule v2 = new Voiture("voiture2", 100, Marque.renault,"moteur2",200,TypeMoteur.essence,40,500, 6, 5);
            v2.AjouterOption(o3);
            v2.Afficher();

            Vehicule c1 = new Camion("camion1", 200000, Marque.citroen, "moteur3", 20555, TypeMoteur.diesel, 20, 500, 2000);
            c1.AjouterOption(o5);
            c1.Afficher();

            Vehicule m1 = new Moto("moto1", 50000, Marque.audi, 2458, "moteur5", 218, TypeMoteur.hybride);
            m1.AjouterOption(o5);
            m1.Afficher();



            //gestion de garage

            Garage  garage = new Garage("Go Garage");

      
            
            garage.AjouterVehivule(v2);
            garage.AjouterVehivule(c1);
            garage.AjouterVehivule(m1);


            Console.WriteLine("ooooooooooooooooo   Test d'affcihage des veichules");
            foreach(Vehicule vehicule in garage.Vehicules)
            {
                vehicule.Afficher();
            }

            Console.WriteLine("test d'affcihage des motos");
            garage.AfficherMoto();



            //test de menu deuxieme partie
            */
        }
    }
}
