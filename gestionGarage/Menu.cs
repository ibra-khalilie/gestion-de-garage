using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace gestionGarage
{
    internal class Menu
    {
        private Garage garage;


        public Menu(Garage garage)
        {
            this.Garage = garage;

            int choixMenu = 0;

            while (choixMenu != 13)
            {
                AfficherMenu(garage);
                choixMenu = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choixMenu)
                    {
                        case 1:
                            garage.Afficher();
                            break;
                        case 2:
                            AjouterVehicule(garage);
 
                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:

                            break;
                        case 9:

                            break;
                        case 10:

                            break;
                        case 11:

                            break;
                        case 12:
                            break;

                        case 13:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public static void AfficherMenu(Garage garage)
        {
            Console.WriteLine(@"
         [--------- Bienvenue dans {0} garage ------]", garage.Nom);
            Console.WriteLine(@"
                    1. Affciher les vehicules
                    2. Ajouter un vehicule
                    3. Suprimer un vehicule
                    4. Sélectionner un vehicule
                    5. Affciher les options d'un vehicules
                    6. Ajouer les options d'un vehicule
                    7. Afficher la liste des comptes
                    8. Affcicher les options
                    9. Afficher les marques
                   10. Affciher les types de moteurs
                   11. Charger le garage
                   12. Sauvergarder le garage
                   13. Quitter l'application
             ");
        }


        public void AjouterVehicule(Garage garage)
        {

            int typeVehicule = 0;
           /* while (typeVehicule != 4)
            {*/
                Console.WriteLine(@"
                Entrez le type de vehicule
                    1. Voiture
                    2. Moto
                    3. Camion
                    4. Retour");

                typeVehicule = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (typeVehicule)
                    {
                        case 1:
                            Vehicule voiture = GestionEntreeVoiture();
                            if ( voiture != null)
                            {
                            garage.AjouterVehivule(voiture);
                            Console.WriteLine("l'ajout est bien pris en compte");
                            }
                           
                            break;
                        case 2:

                            break;
                        case 3:
                            break;

                        case 4:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
        }


        public Vehicule GestionEntreeVoiture()
        {
            Console.Write("Entrer le nom de la voiture : ");
            string nom = Console.ReadLine();

            Console.Write("Entrer le prix : ");
            decimal prix = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Choisir une des marques suivantes :  ");
            Marque marque = ChoisirMarque();

            Console.Write("Entrer la puissance: ");
            int puissance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer le type de moteur : ");
            TypeMoteur moteur = ChoisirMoteur();

            Console.WriteLine("Entrer le nom du moteur: ");
            String nomMoteur = Console.ReadLine();

            Console.Write("Entrer la taille du coffre:");

            int cofrre = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrer le nombre de cheveaux fiscaux :");

            int cFiscaux = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrer le nombre de siège ");
            int nbSiege = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrer le nombre de porte ");
            int nbPorte = Convert.ToInt32(Console.ReadLine());

           return new Voiture(nom, prix, marque, nomMoteur, puissance, moteur, cofrre, cFiscaux, nbSiege, nbPorte);
        }


        
        public Marque ChoisirMarque()
        {
            Marque choixMarque = Marque.peugot;
            int choix = 0;

            foreach (int i in Enum.GetValues(typeof(Marque)))
            {
                Console.WriteLine($" {i} : {Enum.GetName(typeof(Marque), i)}");
            }
            try 
            {
                   
                    
                   choix = Convert.ToInt32(Console.ReadLine());
                   do
                   {
                       Console.WriteLine("Choix incorrect : ");
                       choix = Convert.ToInt32(Console.ReadLine());

                } while (choix > 4);
                 
                switch (choix)
                    {
                        case 0:
                            choixMarque = Marque.peugot;
                            break;
                        case 1:
                            choixMarque = Marque.renault;
                            break;
                        case 2:
                            choixMarque = Marque.citroen;
                            break;
                        case 3:
                            choixMarque = Marque.audi;
                            break;
                        case 4:
                            choixMarque = Marque.ferrai;
                            break;
                    }
                
            }
            catch (Exception)
            {
                Console.WriteLine("la marque peugot est choisit par defaut");
            }
            return choixMarque;
        }


   



        public TypeMoteur ChoisirMoteur()
        {
            TypeMoteur choixMoteur = TypeMoteur.electrique;
            int choix = 0;

            foreach (int i in Enum.GetValues(typeof(TypeMoteur)))
            {
                Console.WriteLine($" {i} : {Enum.GetName(typeof(TypeMoteur), i)}");
            }
            try
            {
                choix = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("Choix incorrect : ");
                    choix = Convert.ToInt32(Console.ReadLine());

                } while (choix > 3);

                switch (choix)
                {
                    case 0:
                        choixMoteur = TypeMoteur.diesel;
                        break;
                    case 1:
                        choixMoteur = TypeMoteur.essence;
                        break;
                    case 2:
                        choixMoteur = TypeMoteur.hybride;
                        break;
                    case 3:
                        choixMoteur = TypeMoteur.electrique;
                        break;
                  
                }

            }
            catch (Exception)
            {
                Console.WriteLine("le moteur élétrique est choisit par defaut");
            }
            return choixMoteur;
        }



        public Garage Garage { get => garage; set => garage = value; }
    }


      
    

}
