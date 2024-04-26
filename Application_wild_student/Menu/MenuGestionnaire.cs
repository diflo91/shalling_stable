using ConsoleApp1;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu
{
    public class MenuGestionnaire
    {


        public void _MenuMngt()
        {
            
            GestionApplication application = new GestionApplication();
            while(true) { 

            

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GlobalAttribute.wildStudent);
            Console.Write("    ");
            Console.WriteLine("                       MENU PRINCIPAL                 ");
            Console.WriteLine("    ");
            Console.Write("    ");
            Console.WriteLine("* CHOISISSEZ LE MENU");
            Console.WriteLine("    ");
                Console.Write("    ");
                Console.WriteLine("[1] ELEVE");
                Console.Write("    ");
                Console.WriteLine("[2] COURS");
                Console.WriteLine("    ");
                Console.Write("    ");
                string ChoixMenuPrincipal = Console.ReadLine() ?? "";
                   
              if (ChoixMenuPrincipal == "1")
                 {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(GlobalAttribute.wildStudent);
                    Console.Write("    ");
                    Console.WriteLine("                       MENU ELEVE                ");
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.WriteLine("* CHOISISSEZ LE MENU");
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.WriteLine("[1] LISTER ELEVES");
                    Console.Write("    ");
                    Console.WriteLine("[2] CREER ELEVE");
                    Console.Write("    ");
                    Console.WriteLine("[3] CONSULTER ELEVE");
                    Console.Write("    ");
                    Console.WriteLine("[4] AJOUTER UNE NOTE ET APPRECIATION");
                    Console.Write("    ");
                    Console.WriteLine("[5] RETOUR MENU PRECEDENT");
                    Console.WriteLine("    ");
                    Console.WriteLine("    ");
                    Console.Write("    ");


                    string ChoixMenuEleve = Console.ReadLine() ?? "";
                     
                    if(ChoixMenuEleve == "1")
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU ELEVE               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* LISTE ELEVES");
                        Console.WriteLine("    ");
                        Console.Write("    ");

                        application.VoirLesEleves();



                    } else if (ChoixMenuEleve == "2")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU CREATION ELEVE               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* IDENTITE ELEVE");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.Write("Identifiant :");
                        Console.Write("    ");
                        int IdEleve = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");
                        Console.Write("Nom :");
                        Console.Write("    ");
                        string NomEleve = Console.ReadLine() ?? ""; 
                        Console.Write("    ");
                        Console.Write("Prenom :");
                        Console.Write("    ");
                        string PrenomEleve = Console.ReadLine()?? "";
                        Console.Write("    ");
                        Console.Write("Date de naissance :");
                        Console.Write("    ");
                        string DateEleve = Console.ReadLine() ?? "";

                        application.AjouterEleve(IdEleve, NomEleve, PrenomEleve, DateEleve);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.WriteLine("    ");
                        Console.WriteLine("                       LA CREATION DE L'ELEVE AVEC SUCCES              ");
                        Console.WriteLine("    ");
                     
                    } else if (ChoixMenuEleve == "3")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU CONSULTATION ELEVE               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* IDENTITE ELEVE");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.Write("Identifiant eleve :");
                        Console.Write("    ");
                        int IdEleve = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");

                        application.AfficherEleve(IdEleve);


                    } else if(ChoixMenuEleve == "4") 
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU AJOUT NOTE ELEVE               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* IDENTITE ELEVE");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.Write("Identifiant eleve :");
                        Console.Write("    ");
                        int IdEleve = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");
                        Console.Write("Identifiant cours :");
                        Console.Write("    ");
                        int IdCours = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");
                        Console.Write("Note :");
                        Console.Write("    ");
                        double Note = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");
                        Console.Write("Appreciation :");
                        Console.Write("    ");
                        string Appreciation = Console.ReadLine() ?? "";
                        Console.Write("    ");

                        application.AjouterNotePourEleve(IdEleve, IdCours, Note, Appreciation);

                    } else if (ChoixMenuEleve == "5")
                    {
                        break;
                    }



                } else if (ChoixMenuPrincipal == "2")

                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(GlobalAttribute.wildStudent);
                    Console.Write("    ");
                    Console.WriteLine("                       MENU COURS               ");
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.WriteLine("* CHOISISSEZ LE MENU");
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.WriteLine("[1] LISTER COURS");
                    Console.Write("    ");
                    Console.WriteLine("[2] AJOUTER COURS");
                    Console.Write("    ");
                    Console.WriteLine("[3] SUPPRIMER COURS");
                    Console.Write("    ");
                    Console.WriteLine("[4] RETOUR MENU PRECEDENT");
                    Console.WriteLine("    ");
                    Console.WriteLine("    ");
                    Console.Write("    ");

                    string ChoixMenuCours = Console.ReadLine() ?? "";

                    if (ChoixMenuCours == "1")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU LISTE COURS               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* COURS");
                        Console.WriteLine("    ");
                        Console.Write("    ");

                        application.VoirLesCours();


                    } else if (ChoixMenuCours == "2")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU AJOUTER COURS               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* COURS");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.Write("IDENTIFIANT DU COURS :");
                        Console.Write("    ");
                        int IdCours = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");
                        Console.Write("NOM  :");
                        Console.Write("    ");
                        string NomCours = Console.ReadLine() ?? "";
                        Console.Write("    ");

                        application.AjouterCours(IdCours, NomCours);

                    } else if (ChoixMenuCours == "3")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU SUPPRIMER COURS               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("* COURS");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.Write("IDENTIFIANT DU COURS :");
                        Console.Write("    ");
                        int IdCours = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("    ");


                        application.SupprimerCours(IdCours);

                    } else if (ChoixMenuCours == "4")
                            {
                        break;
                    } else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       ERREUR               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("Choisissez le bon menu");
                        Console.WriteLine("    ");

                    }



                } else
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(GlobalAttribute.wildStudent);
                    Console.Write("    ");
                    Console.WriteLine("                       MENU PRINCIPAL                 ");
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.WriteLine("Vous avez saissi une mauvaise option");
                }





                Console.ReadLine();
                     }
        }
         

    }
}
