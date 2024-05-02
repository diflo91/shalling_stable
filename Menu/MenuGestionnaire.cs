
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
            application.LoadDataFromJson();

            GlobalAttribute.logger.WriteLog("L'utilisateur a accedé dans le menu principal.");

            while (true) { 

            

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
                    GlobalAttribute.logger.WriteLog($"L'utilisateur a accedé au Menu Eleve.");
                    while (ChoixMenuPrincipal == "1") { 
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

                        application.VoirLesEleves();
                        Console.ReadLine();
                           

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

                        application.AjouterEleve(NomEleve, PrenomEleve, DateEleve);
                            
                            Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.WriteLine("    ");
                        Console.WriteLine("                       LA CREATION DE L'ELEVE AVEC SUCCES              ");
                        Console.WriteLine("    ");
                        Console.ReadLine();

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
                        string IdEleve = Console.ReadLine();
                        Console.Write("    ");

                            if (IdEleve == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("    ");
                                Console.WriteLine("Erreur de saisie !");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.ReadLine();
                            }
                            else if (IdEleve != "")
                            {
                            application.AfficherEleve(int.Parse(IdEleve));
                            Console.ReadLine();
                            }

                        } else if(ChoixMenuEleve == "4") 
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU AJOUT NOTE ELEVE               ");
                        Console.WriteLine("    ");
                            Console.Write("    ");
                            Console.WriteLine("MENU DES COURS EXISTANTS");
                            Console.WriteLine("    ");

                            application.VoirLesCours();

                            if (application.cours.Count != 0)
                            {

                                Console.WriteLine();
                                Console.Write("    ");
                                Console.WriteLine("* IDENTITE ELEVE");
                                Console.WriteLine("    ");
                                Console.Write("    ");
                                Console.Write("Identifiant eleve :");
                                Console.Write("    ");

                                string IdEleveTry = Console.ReadLine()?? "" ;
                                int IdEleve;
                                bool isValideEleve = int.TryParse(IdEleveTry, out IdEleve);

                              

                                 if (isValideEleve) {

                                    bool EleveExist = application.CheckEleveExist(IdEleve);

                                    if (EleveExist)
                                    {

                                        Console.Write("    ");
                                        Console.Write("Identifiant cours :");
                                        Console.Write("    ");

                                        string IdCoursSaisie = Console.ReadLine() ?? "";
                                        int IdCours;
                                        bool isCoursValide = int.TryParse(IdCoursSaisie, out IdCours);

                                        if (isCoursValide)
                                        {
                                            bool CoursExist = application.CheckCoursExist(IdCours);

                                            if (CoursExist)
                                            {
                                                
                                               
                                                Console.Write("    ");
                                                Console.Write("Note :");
                                                Console.Write("    ");

                                                string NoteSaisi = Console.ReadLine() ?? "";
                                                double Note;
                                                bool isValideNote = double.TryParse(NoteSaisi, out Note);


                                                if (isValideNote)
                                                {

                                                    Console.Write("    ");
                                                    Console.Write("Appreciation :");
                                                    Console.Write("    ");
                                                    string Appreciation = Console.ReadLine() ?? "";
                                                    Console.Write("    ");


                                                    application.AjouterNotePourEleve(IdEleve, IdCours, Note, Appreciation);
                                                }
                                                else if (!isValideNote)
                                                {
                                                    //while (!isValideNote) { 
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine();
                                                    Console.Write("    ");
                                                    Console.WriteLine(" La note est obligatoire !");
                                                    Console.ResetColor();
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.ReadLine();
                                                        
                                                   // }
                                                }
                                            }
                                            else if (!CoursExist)
                                            {

                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine();
                                                Console.Write("    ");
                                                Console.WriteLine("Ce Cours n'existe pas !");
                                                Console.ResetColor();
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.ReadLine();
                                            }
                                        }
                                            else if (!isCoursValide)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine();
                                                Console.Write("    ");
                                                Console.WriteLine("Erreur de saisie !");
                                                Console.ResetColor();
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.ReadLine();
                                            }
                                        
                                    } else if (!EleveExist)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine();
                                        Console.Write("    ");
                                        Console.WriteLine("Cet Elève n'existe pas !");
                                        Console.ResetColor();
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.ReadLine();
                                    }

                             } else if (!isValideEleve)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine();
                                    Console.Write("    ");
                                    Console.WriteLine("Erreur de saisie !");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.ReadLine();
                                }

                            } else if (application.cours.Count == 0)
                            {
                               
                                Console.ReadLine();
                            }

                    } else if (ChoixMenuEleve == "5")
                    {
                        break;
                    } else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.Write("    ");
                            Console.WriteLine("Erreur de saisie !");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.ReadLine();
                        }





                    }


                } else if (ChoixMenuPrincipal == "2")

                {
                    GlobalAttribute.logger.WriteLog($"L'utilisateur a accedé au Menu Cours.");
                    while (ChoixMenuPrincipal == "2") { 
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

                        application.VoirLesCours();
                        Console.ReadLine();


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
                        Console.Write("NOM  :");
                        Console.Write("    ");
                        string NomCours = Console.ReadLine() ?? "";
                        Console.Write("    ");

                        application.AjouterCours(NomCours);

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
                        string IdCoursStr = Console.ReadLine() ?? "";
                            int IdCours;
                            bool isTrue = int.TryParse(IdCoursStr, out IdCours);
                            
                        Console.Write("    ");

                            if(IdCoursStr != "")
                            {
                                Console.WriteLine("");
                                Console.Write("    ");
                                Console.Write("Souhaitez-vous supprimer ce cours ? ");
                                Console.ForegroundColor = ConsoleColor.Red;  
                                Console.Write("Oui ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.ResetColor(); Console.Write("ou  ");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green; 
                                Console.Write("Non ? :"); 
                                Console.ResetColor();
                                Console.Write("    ");
                                string choixConfirm = Console.ReadLine() ?? "";

                                 if (choixConfirm.ToLower() == "oui")
                                {
                                         application.SupprimerCours(IdCours);
                                         Console.ReadLine();

                                } else if (choixConfirm.ToLower() == "non")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("");
                                    Console.Write("   ");
                                    Console.WriteLine("Vous avez abandonné !");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                }
                            } else if (IdCoursStr == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("");
                                Console.Write("    ");
                                Console.WriteLine("Vous avez abandonné !");
                                Console.ResetColor (); 
                                Console.ReadLine();
                            }

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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Choisissez le bon menu");
                            Console.ResetColor();
                        Console.WriteLine("    ");
                        Console.ReadLine();

                    }
                    }
                } 
                else
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(GlobalAttribute.wildStudent);
                    Console.Write("    ");
                    Console.WriteLine("                       MENU PRINCIPAL                 ");
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous avez saissi une mauvaise option !");
                    Console.ResetColor();   
                    Console.ReadLine(); 
                    
                }   
           }
        }
         

    }
}
