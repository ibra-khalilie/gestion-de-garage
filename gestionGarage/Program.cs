using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

            
            Garage garage = new Garage("Go-MAM");

            //List<Garage> garages = garage.Charger<List<Garage>>("dataUsers.bin");
            //garage.Sauvergarde(garages, "dataUsers.bin");




            // new Menu(new Garage("Go")).GetChoixMenu();
            Moteur moteur = new Moteur("MoteurMMA", 500, TypeMoteur.hybride);
            Moteur moteur1 = new Moteur("LAV", 100, TypeMoteur.electrique);
            Moteur moteur2 = new Moteur("LOREN", 600, TypeMoteur.diesel);

            garage.Moteurs.Add(moteur);
            garage.Moteurs.Add(moteur1);
            garage.Moteurs.Add(moteur2);

            //test de camion

            //  Vehicule camion  = new Camion()

            Option o1 = new Option("Climatiseur", 200);
            Option o2 = new Option("Camera", 400);
            Option o3 = new Option("Dectecteur de fatique", 500);
            Option o4 = new Option("JeuxdeLumiere", 500);
            Option o5 = new Option("AA45", 500);
            Voiture v = new Voiture("name", 2500, Marque.renault, moteur, 250, 120, 2, 2);
            v.AjouterOption(o1);
            v.AjouterOption(o2);

            garage.Option.Add(o1);
            garage.Option.Add(o2);
            garage.Option.Add(o3);
            garage.Option.Add(o4);
            garage.Option.Add(o5);
          //  v.PrixTotal();
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


            //Test de chargement de fichier


            List<Vehicule> vehicule = Charger<List<Vehicule>>("data.bin");

            if (vehicule == null)
            {
                Moteur m = new Moteur(); m.Nom = "Mot6500"; m.Type = TypeMoteur.electrique;
                vehicule = new List<Vehicule>();
                vehicule.Add(new Voiture()
                {
                    Nom = "Paul",
                    Marque = Marque.renault,
                    Moteur = m,
                    ChevauxFiscaux = 250,
                    NbPorte = 5,
                    NbSiege = 4,
                    TailleCoffre = 200,
                    PrixHT = 20000,
                });

                Sauvergarde(vehicule, "data.bin");

                List<Vehicule> vehicule1 = Charger<List<Vehicule>>("data.bin");
                Console.WriteLine(vehicule1[0].Nom);
            }
          
         
            new Menu(garage).Start();
          
        }

        private static void Sauvergarde(List<Vehicule> vehicule, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream flux = null;
            try
            {
                flux = new FileStream(path, FileMode.Create, FileAccess.Write);
                formatter.Serialize(flux, vehicule);
                flux.Flush();
            }
            catch { }
            finally
            {
                //On ferme le flux
                if (flux != null) flux.Close();
            }



        }

        static List<Vehicule> Charger<T>(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream flux = null;
            try
            {
                flux = new FileStream(path, FileMode.Open, FileAccess.Read);
                return (List<Vehicule>)formatter.Deserialize(flux);
            }
            catch 
            {
                return default(List<Vehicule>);
            }
            finally { 
                if (flux != null) flux.Close();
            }
        }




    }
    }