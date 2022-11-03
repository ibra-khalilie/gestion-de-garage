using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
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

        }
   

        public void Start()
        {
            int choixMenu = 0;

            while (choixMenu != 13)
            {
                AfficherMenu(garage);
                try
                {
                    choixMenu = GetChoixMenu();
                
                    switch (choixMenu)
                    {
                        
                        case 1:
                            garage.Afficher();
                            break;
                        case 2:
                            AjouterVehicule(garage);
                            break;
                        case 3:
                            SupprimerVehicule(garage);
                            // GetChoix();
                            break;
                        case 4:
                            SelectionnerVehicule(garage);
                            break;
                        case 5:
                            AfficherOptionsVehicule(garage);

                            break;
                        case 6:
                            AjouterOptionVehicule(garage);
                            break;
                        case 7:
                            SupprimerOption(garage);
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
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
                    7. Supprimer option
                    8. Affcicher les options
                    9. Afficher les marques
                   10. Afficher les types de moteurs
                   11. Charger le garage
                   12. Sauvergarder le garage
                   13. Quitter l'application
             ");
        }



        public void AjouterVehicule(Garage garage)
        {
            int typeVehicule = 0;
            while (typeVehicule != 5)
            {
                Console.WriteLine(@"
                Entrez le type de vehicule
                    1. Voiture
                    2. Moto
                    3. Camion
                    4. Retour
                    5. Annuler"); ;

                typeVehicule = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (typeVehicule)
                    {
                        case 1:
                            Vehicule voiture = GestionEntreeVoiture();
                            if (voiture != null)
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
        }



        public void SupprimerVehicule(Garage garage)

            
        {
           
            for(int i = 0; i < garage.Vehicules.Count; i++)
            {
                //todo
                Console.WriteLine( "Id :  : " + garage.Vehicules[i].Id+
                                   "\nNom : " +garage.Vehicules[i].Nom+"\n");
            }
            Console.WriteLine("Veuiller séléctionner l'id de vehicule à supprimer");
            int choix = GetChoix();

            int j = 0;
            while (j!=garage.Vehicules.Count && garage.Vehicules[j].Id != choix)
            {
                j++;
            }
            if (j == garage.Vehicules.Count)
            {
                Console.WriteLine("l'indefifiant n'existe pas");
            }else if (garage.Vehicules[j].Id == choix)
            {
               bool res =  garage.Vehicules.Remove(garage.Vehicules[j]);
               if(res == true)
                {
                    Console.WriteLine("Suppression bien réussi");
                }
                else
                {
                    Console.WriteLine("Echec de suppréssion");
                }
             
            }
        }


        public void SelectionnerVehicule(Garage garage)
        {
            for (int i = 0; i < garage.Vehicules.Count; i++)
            {
                //todo
                Console.WriteLine("Id :  : " + garage.Vehicules[i].Id +
                                   "\nNom : " + garage.Vehicules[i].Nom + "\n");
            }
            Console.WriteLine("Veuiller séléctionner l'id du vehicule");
            int choix = GetChoix();

            int j = 0;
            while (j != garage.Vehicules.Count && garage.Vehicules[j].Id != choix)
            {
                j++;
            }
            if (j == garage.Vehicules.Count)
            {
                Console.WriteLine("l'indefifiant de ce véhicule n'existe pas");
            }
            else if (garage.Vehicules[j].Id == choix)
            {
              garage.Vehicules[j].Afficher();
           

            }
        }

        //Afficher les options d'un vehicules
        public void AfficherOptionsVehicule(Garage garage)
        {

            for (int i = 0; i < garage.Vehicules.Count; i++)
            {
           
                Console.WriteLine("Id :  : " + garage.Vehicules[i].Id +
                                   "\nNom : " + garage.Vehicules[i].Nom + "\n");
            }
            Console.WriteLine("Veuiller séléctionner l'id du vehicule");
            int choix = GetChoix();

            int j = 0;
            while (j != garage.Vehicules.Count && garage.Vehicules[j].Id != choix)
            {
                j++;
            }
            if (j == garage.Vehicules.Count)
            {
                Console.WriteLine("l'indefifiant de ce véhicule n'existe pas");
            }
            else if (garage.Vehicules[j].Id == choix)
            {
                garage.Vehicules[j].AfficherOptions();


            }
        }


        //Ajouter les options d'un vehicules

        public void AjouterOptionVehicule(Garage garage)
        {

            for (int i = 0; i < garage.Vehicules.Count; i++)
            {

                Console.WriteLine("Id :  : " + garage.Vehicules[i].Id +
                                   "\nNom : " + garage.Vehicules[i].Nom + "\n");
            }
            Console.WriteLine("Veuiller séléctionner l'id du vehicule");
            int choix = GetChoix();

            int j = 0;
            while (j != garage.Vehicules.Count && garage.Vehicules[j].Id != choix)
            {
                j++;
            }
            if (j == garage.Vehicules.Count)
            {
                Console.WriteLine("l'indefifiant de ce véhicule n'existe pas");
            }
            else if (garage.Vehicules[j].Id == choix)
            {

                Option option = new Option();
                Console.Write("Mettez le nom de l'option : ");
                String nomOp = Console.ReadLine();
                option.Nom = nomOp;
                Console.Write("Mettez le prix de l'otpion : ");
                decimal prixOp = Convert.ToDecimal(Console.ReadLine());
                option.Prix = prixOp;
                garage.Vehicules[j].AjouterOption(option);
                Console.WriteLine("L'option est bien enregistré pour le vehicule : "+ garage.Vehicules[j].Nom);

            }




        }



        public void SupprimerOption(Garage garage)
        {


            for (int i = 0; i < garage.Vehicules.Count; i++)
            {

                Console.WriteLine("Id :  : " + garage.Vehicules[i].Id +
                                   "\nNom : " + garage.Vehicules[i].Nom + "\n");
            }
            Console.WriteLine("Veuiller séléctionner l'id du vehicule");
            int choix = GetChoix();

            int j = 0;
            while (j != garage.Vehicules.Count && garage.Vehicules[j].Id != choix)
            {
                j++;
            }
            if (j == garage.Vehicules.Count)
            {
                Console.WriteLine("l'indefifiant de ce véhicule n'existe pas");
            }
            else if (garage.Vehicules[j].Id == choix)
            {

                Console.WriteLine("Veuiller sélectionner l'id de l'option ");
                garage.Vehicules[j].AfficherOptions();
                int choixOption = GetChoix();
          
                int k = 0;
                while (k != garage.Vehicules[j].Options.Count && garage.Vehicules[j].Options[k].Id != choixOption)
                {
                    k++;
                }
                if (k == garage.Vehicules[j].Options.Count)
                {
                    Console.WriteLine("l'indefifiant de ce véhicule n'existe pas");
                }
                else if (garage.Vehicules[j].Options[k].Id == choixOption)
                {

                    if(garage.Vehicules[j].Options.Remove(garage.Vehicules[j].Options[k])) Console.WriteLine("Option bien supprimé");

                }

                
            }








            /*   if (TrouverOption(garage.Vehicules[j].Options, choixOption))
               {
                   bool res = garage.Vehicules[j].Options.Remove(garage.Vehicules[j].Options[choixOption]);
                   if (res) { Console.WriteLine("L'option est a été bien supprimer"); }
                   else { Console.WriteLine("Echec de suppression !"); }
               }
               else
               {
                   Console.WriteLine("Identifiant option inexistant");
               }
            */





        

        }



      public bool TrouverOption(List<Option> option,int choix)
        {

            bool trouve = false;

            int j = 0;
            while (j != option.Count && option[j].Id != choix)
            {
                j++;
            }
            if (j == option.Count)
            {
                Console.WriteLine("l'indefifiant de ce véhicule n'existe pas");
                trouve = false;
            }
            else if (option[j].Id == choix)
            {
                trouve = true;

            }

            return trouve;
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

                   } while (choix < 0 || choix> 4);
                 
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

                } while (choix < 0 || choix > 4);

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





        public int GetChoixMenu()
        {
           
                int  choix = GetChoix();

                if (choix < 1 || choix > 13){throw new MenuException(); }

             return choix;
        }

        public int GetChoixUsers(int min, int max)
        {

            int choix = GetChoix();

            if (choix < min|| choix > max) { throw new MenuException(); }

            return choix;
        }





        public int GetChoix()
        {
            int choixUser = 0;
                try{
                    choixUser =  Convert.ToInt32(Console.ReadLine());
                }catch(FormatException )
                  {
                    Console.WriteLine ("Le choix saisit n'est pas un nombre");
                  }
            return choixUser;
        }




        public Garage Garage { get => garage; set => garage = value; }















        //classe MenuException

        class MenuException : Exception
        {
            public MenuException() :
                base("Le choix n'est pas compris entre 1 et 13")
            {
                
            }

            public MenuException(string message) 
                :base("Le choix n'est pas compris entre 1 et 13")
            {
            }

            public MenuException(string message, Exception innerException) 
                : base(message, innerException)
            {
            }

            protected MenuException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }





   
}
