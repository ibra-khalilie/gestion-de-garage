using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
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
        public Menu()
        {
            
        }
   

        public void Start()
        {
            int choixMenu = 0;

            while (choixMenu != 14)
            {
                AfficherMenu(garage);
                try
                {
                    choixMenu = GetChoixMenu();
                
                    switch (choixMenu)
                    {
                        
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            garage.Afficher();
                            Console.ForegroundColor = ConsoleColor.Cyan;
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
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Liste des options dans le garage\n");
                            foreach (Option option in garage.Option)
                            {
                             
                                Console.WriteLine("ID : "+option.Id+ "| NOM : "+option.Nom+" | PRIX : "+option.Prix);
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Liste des marques ");
                            foreach (int i in Enum.GetValues(typeof(Marque)))
                            {
                                Console.WriteLine($" {i} : {Enum.GetName(typeof(Marque), i)}");
                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            break;
                        case 10:
                            garage.AjouterMoteur();
                        
                            break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Liste des marques ");

                            foreach (int i in Enum.GetValues(typeof(TypeMoteur)))
                            {
                                Console.WriteLine($" {i} : {Enum.GetName(typeof(TypeMoteur), i)}");
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            /*  foreach (Moteur moteur in garage.Moteurs)
                              {

                                      moteur.Afficher();

                              }*/

                            break;

                        case 12:
                            if (Charger("dataUsers.bin") == null)
                            {
                                Console.WriteLine("Chargement non réussi");
                            }
                            else
                            {
                                Console.WriteLine("Chargement non réussi");
                            };
                            break;

                        case 13:
                            Sauvergarde(garage.Vehicules,"dataUsers.bin");
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
                    1. Afficher les vehicules
                    2. Ajouter un vehicule
                    3. Suprimer un vehicule
                    4. Sélectionner un vehicule
                    5. Afficher les option d'un vehicules
                    6. Ajouter des options à un vehicule
                    7. Supprimer option
                    8. Afficher les options
                    9. Afficher les marques
                   10. Ajouter Moteur
                   11. Afficher les types de moteurs
                   12. Charger le garage
                   13. Sauvergarder le garage
                   14. Quitter l'application
             ");
        }


        public void AjouterVehicule(Garage garage)
        {
            int typeVehicule = 0;
            while (typeVehicule != 4)
            {
                Console.WriteLine(@"
                Entrez le type de vehicule
                    1. Voiture
                    2. Moto
                    3. Camion
                    4. Retour
                            "); ;

                typeVehicule = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (typeVehicule)
                    {
                        case 1:
                            Vehicule voiture = AjouterUneVoiture(garage);
                            if (voiture != null)
                            {
                                garage.AjouterVehivule(voiture);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"
                                 ----------------------
                                     - Succèes !-
                                - Ajout bien reussi - ");

                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                            break;
                        case 2:

                            Vehicule moto = AjouterUneMoto(garage);
                            if (moto != null)
                            {
                                garage.AjouterVehivule(moto);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"
                                 ----------------------
                                     - Succèes !-
                                - Ajout bien reussi - ");

                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }

                            break;
                        case 3:

                            Vehicule camion = AjouterUnCamion(garage);
                            if (camion != null)
                            {
                                garage.AjouterVehivule(camion);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"
                                 ----------------------
                                     - Succèes !-
                                - Ajout bien reussi - ");

                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }

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

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
                      Voudriez-vous supprimer ce vehicule ?
                                   1 : Oui 
                                   2 : Non");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int rep = Convert.ToInt32(Console.ReadLine());
                if (rep == 1)
                {
                    bool res = garage.Vehicules.Remove(garage.Vehicules[j]);
                    if (res == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@"
                                 ----------------------
                                     - Succèes !-5

                               - Suppression bien reussi - ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.WriteLine("Echec de suppréssion");
                    }
                }
                else
                {
                    Console.WriteLine("Choix incorrect");
                }
               
             
            }
        }


        public void SelectionnerVehicule(Garage garage)
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
              
                
                    Console.WriteLine("Veuiller entrer le numéro de l'option");

                    AfficherLesOptionsDuGarages(garage);

                    int choixU = Convert.ToInt32(Console.ReadLine());

                    int m = 0;
                    while (m != garage.Option.Count && garage.Option[m].Id != choixU)
                    {

                        m++;
                    }
                    if (m == garage.Option.Count)
                    {
                        Console.WriteLine("l'indefifiant de cette option n'existe pas");
                    }
                    else if (garage.Option[m].Id == choixU)
                    {

                      
                        garage.Vehicules[j].AjouterOption((garage.Option[m]));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
                                 ----------------------
                                     - Succèes !-
                                - Ajout bien reussi - ");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.WriteLine("je sort et je n'ai rien rajouter");
                }

                
      


            }

        }


        public void AfficherLesOptionsDuGarages(Garage garage)
        {
            foreach (Option option in garage.Option)
            {
                option.Afficher();
            }
        }



        public void SupprimerOption(Garage garage)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < garage.Vehicules.Count; i++)
            {

                Console.WriteLine("Id :  : " + garage.Vehicules[i].Id +
                                   "\nNom : " + garage.Vehicules[i].Nom + "\n");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"
                      Voudriez-vous supprimer cette Option ?
                                   1 : Oui 
                                   2 : Non");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int rep = Convert.ToInt32(Console.ReadLine());
                    if (rep == 1)
                    {
                        if (garage.Vehicules[j].Options.Remove(garage.Vehicules[j].Options[k]))
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"
                                 ----------------------
                                     - Succèes !-

                             - Suppression bien reussi - ");
                        Console.ForegroundColor = ConsoleColor.Cyan;

                    }
                    else
                    {
                        Console.WriteLine("Choix Incorrect");
                    }

                }

                
            }


        

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


    





    public Vehicule AjouterUneVoiture(Garage garage)
        {
            Voiture voiture = new Voiture();

            Console.Write("Entrer le nom de la voiture : ");
            string nom = Console.ReadLine();
            voiture.Nom = nom;



            Console.Write("Entrer le prix : ");
            decimal prix = Convert.ToDecimal(Console.ReadLine());
            voiture.PrixHT = prix;

            Console.WriteLine("Choisir une des marques suivantes :  ");
            Marque marque = ChoisirMarque();
            voiture.Marque = marque;

            Console.WriteLine ("Veuiller choisir l'id d'un Moteur : ");
            Moteur moteur = ChoisirMoteur(garage);
            voiture.Moteur = moteur;
           

            Console.Write("Entrer la taille du coffre:");
            int cofre = Convert.ToInt32(Console.ReadLine());
            voiture.TailleCoffre = cofre;


            Console.Write("Entrer le nombre de cheveaux fiscaux :");
            int cFiscaux = Convert.ToInt32(Console.ReadLine());
            voiture.ChevauxFiscaux = cFiscaux;

            Console.Write("Entrer le nombre de siège ");
            int nbSiege = Convert.ToInt32(Console.ReadLine());
            voiture.NbSiege = cFiscaux;

            Console.Write("Entrer le nombre de porte ");
            int nbPorte = Convert.ToInt32(Console.ReadLine());
            voiture.NbPorte = nbPorte;

            return voiture;
           
        }

        public Vehicule AjouterUneMoto(Garage garage) {


            Moto moto = new Moto();
            Console.Write("Entrer le nom de la moto : ");
            string nom = Console.ReadLine();
            moto.Nom = nom;



            Console.Write("Entrer le prix : ");
            decimal prix = Convert.ToDecimal(Console.ReadLine());
            moto.PrixHT = prix;

            Console.WriteLine("Choisir une des marques suivantes :  ");
            Marque marque = ChoisirMarque();
            moto.Marque = marque;

            Console.WriteLine("Veuiller choisir l'id d'un Moteur : ");
            Moteur moteur = ChoisirMoteur(garage);
            moto.Moteur = moteur;

            Console.WriteLine("Veuiller entrez la taille du cylindre: ");
            int cylindre= Convert.ToInt32(Console.ReadLine()); ;
            moto.Cylindre = cylindre;


            return moto;
        }


        public Vehicule AjouterUnCamion(Garage garage)
        {


            Camion camion = new Camion();
            Console.Write("Entrer le nom du camion : ");
            string nom = Console.ReadLine();
            camion.Nom = nom;

            Console.Write("Entrer le prix : ");
            decimal prix = Convert.ToDecimal(Console.ReadLine());
            camion.PrixHT = prix;

            Console.WriteLine("Choisir une des marques suivantes :  ");
            Marque marque = ChoisirMarque();
            camion.Marque = marque;

            Console.WriteLine("Veuiller choisir l'id d'un Moteur : ");
            Moteur moteur = ChoisirMoteur(garage);
            camion.Moteur = moteur;


            Console.WriteLine("Veuiller entrez le nombre de d'essieu: ");
            int nbEssieu = Convert.ToInt32(Console.ReadLine());
            camion.NbEssieu = nbEssieu;


            Console.WriteLine("Veuiller entrez le poid: ");
            int poid = Convert.ToInt32(Console.ReadLine());
            camion.Poid = poid;

            Console.WriteLine("Veuiller entrez le volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());
            camion.Volume = volume;


            return camion;
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


                while (choix < 0 || choix > 4)
                {
                    Console.WriteLine("Choix incorrect : ");
                     choix = Convert.ToInt32(Console.ReadLine());
                }
                
             
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

        public Moteur ChoisirMoteur(Garage garage)
        {
            Moteur moteur = null;

            for (int i = 0; i < garage.Moteurs.Count; i++)
            {
                Console.WriteLine("ID : " + garage.Moteurs[i].Id + " | Nom : " + garage.Moteurs[i].Nom + " | Puissance : " + garage.Moteurs[i].Puissance);
            }

            do
            {
                int choix = Convert.ToInt32(Console.ReadLine());

                int j = 0;
                while (j != garage.Moteurs.Count && garage.Moteurs[j].Id != choix)
                {
                    j++;
                }


                if (j == garage.Moteurs.Count)
                {
                    Console.WriteLine("l'indefifiant de ce moteur n'existe pas, veuillez choisir un moteur :");
                }
                else if (garage.Moteurs[j].Id == choix)
                {

                    moteur = garage.Moteurs[j];

                }

            }while(moteur == null);
           

            return moteur;
        }



        public TypeMoteur ChoisirTypeMoteur()
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

                while (choix < 0 || choix > 4)
                {
                    Console.WriteLine("Choix incorrect : ");
                    choix = Convert.ToInt32(Console.ReadLine());
                }


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


        public void Sauvergarde(List<Vehicule> vehicule, string path)
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


        public  List<Vehicule> Charger(string path)
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
            finally
            {
                if (flux != null) flux.Close();
            }
        }



        public int GetChoixMenu()
        {
           
                int  choix = GetChoix();

                if (choix < 1 || choix > 14){throw new MenuException(); }
           
          
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




        public Garage Garage {
            get => garage; set => garage = value;
        }



        //classe MenuException

        class MenuException : Exception
        {
            public MenuException() :
                base("Le choix n'est pas compris entre 1 et 14")
            {
                
            }

            public MenuException(string message) 
                :base("Le choix n'est pas compris entre 1 et 14")
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
