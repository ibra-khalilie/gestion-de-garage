using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Garage garage = new Garage("Go");



            // new Menu(new Garage("Go")).GetChoixMenu();
            Moteur moteur = new Moteur("MoteurMMA", 500, TypeMoteur.hybride);
            Moteur moteur1 = new Moteur("LAV", 100, TypeMoteur.electrique) ;
            Moteur moteur2 = new Moteur("LOREN", 600, TypeMoteur.diesel);

            garage.Moteurs.Add(moteur);
            garage.Moteurs.Add(moteur1);
            garage.Moteurs.Add(moteur2);

            //test de camion

          //  Vehicule camion  = new Camion()

            Option o1 = new Option("Climatiseur", 200);
            Option o2 = new Option("Camera", 400);
            Option o3 = new Option("Dectecteur de fatique", 500);
            //Option o4 = new Option("", 500);
            //Option o5 = new Option("tt", 500);
            Voiture v = new Voiture("name", 2500,Marque.renault,moteur,250,120,2,2) ;
            v.AjouterOption(o1);
            v.AjouterOption(o2);

            garage.Option.Add(o1);
            garage.Option.Add(o2);
            garage.Option.Add(o3);
            v.PrixTotal();
            // v.Afficher();

          //  Vehicule v2 = new Voiture("voiture2", 100, Marque.renault, "moteur2", 200, TypeMoteur.essence, 40, 500, 6, 5);
         //   v2.AjouterOption(o3);
            // v2.Afficher();

          // Vehicule c1 = new Camion("camion1", 200000, Marque.citroen, moteur1,20,250,25);
            garage.Vehicules.Add(v);
           // c1.AjouterOption(o5);
            // c1.Afficher();

           // Vehicule m1 = new Moto("moto1", 50000, Marque.audi, 2458, "moteur5", 218, TypeMoteur.hybride);
           // m1.AjouterOption(o5);
            //m1.Afficher();



            //gestion de garage

          



        //    garage.AjouterVehivule(v2);
           // garage.AjouterVehivule(c1);
        //    garage.AjouterVehivule(m1);

            /*
                        Console.WriteLine("ooooooooooooooooo   Test d'affcihage des veichules");
                        foreach(Vehicule vehicule in garage.Vehicules)
                        {
                            vehicule.Afficher();
                        }

                        Console.WriteLine("test d'affcihage des motos");
                        garage.AfficherMoto();



                        //test de menu deuxieme partie

                    }
                }*/


            new Menu(garage).Start();
        }
    }
    }