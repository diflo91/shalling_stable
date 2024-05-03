
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
                Console.Write("    ");
                Console.WriteLine("[3] PROMOTIONS");
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


                            
                            bool dateValide = false;
                            bool moisValide = false;
                            bool yearValide = false;
                            string Day;
                            string Mois;
                            string Year;
                            
                            int DayAsInt;
                            int MoisAsInt;
                            int YearAsInt;

                            
                            do {

                                Console.Write("Date de naissance :");
                                Console.Write("    ");

                                ConsoleKeyInfo keyDate_1 = Console.ReadKey();
                                ConsoleKeyInfo keyDate_2 = Console.ReadKey();

                                Day = (keyDate_1.KeyChar.ToString()) + (keyDate_2.KeyChar.ToString());

                                    if (int.TryParse(Day, out DayAsInt))
                                    {

                                        if (DayAsInt >= 1 && DayAsInt <= 31)
                                        {
                                            dateValide = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine();
                                            Console.Write("   ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" Le jour doit être compris entre 1 et 31 ! ");
                                            Console.ResetColor(); Console.Write("    ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.Write("   ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" Entrer une date valide");
                                        Console.ResetColor(); Console.Write("    ");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                
                            } while (!dateValide);


                                Console.Write("/");


                                do
                                {

                                    ConsoleKeyInfo keyMois_1 = Console.ReadKey();
                                    ConsoleKeyInfo keyMois_2 = Console.ReadKey();
                                    Mois = (keyMois_1.KeyChar.ToString()) + (keyMois_2.KeyChar.ToString());

                                    if (int.TryParse(Mois, out MoisAsInt))
                                    {

                                        if (MoisAsInt >= 1 && MoisAsInt <= 12)
                                        {
                                            moisValide = true;
                                        }
                                        else
                                        {

                                            Console.WriteLine();
                                            Console.Write("   ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" Le Mois doit être compris entre 1 et 12 ! ");
                                            Console.ResetColor(); Console.Write("    ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write($"Date de naissance :  {Day}/");
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.Write("   ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" Entrer un Mois valide");
                                        Console.ResetColor(); Console.Write("    ");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Write($"Date de naissance :  {Day}/");
                                    }
                                
                            } while (!moisValide);



                            Console.Write("/");


                                do
                                {


                                    ConsoleKeyInfo keyAnnee_1 = Console.ReadKey();
                                    ConsoleKeyInfo keyAnnee_2 = Console.ReadKey();
                                    ConsoleKeyInfo keyAnnee_3 = Console.ReadKey();
                                    ConsoleKeyInfo keyAnnee_4 = Console.ReadKey();
                                    Console.Write(".");

                                    Year = (keyAnnee_1.KeyChar.ToString()) + (keyAnnee_2.KeyChar.ToString()) + (keyAnnee_3.KeyChar.ToString()) + (keyAnnee_4.KeyChar.ToString());
                                    DateTime YearToNow = DateTime.Now;
                                    int YearToNowAsInt = YearToNow.Year;

                                    if (int.TryParse(Year, out YearAsInt))
                                    {


                                        if (YearAsInt <= YearToNowAsInt)
                                        {
                                            yearValide = true;
                                        }
                                        else
                                        {

                                            Console.WriteLine();
                                            Console.Write("   ");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine($" Vous n'ête pas un alien, l'année doit etre inferieure à l'année courante {YearToNow} ! ");
                                            Console.ResetColor(); Console.Write("    ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write($"Date de naissance :  {Day}/{Mois}/");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.Write("   ");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" Entrer une année valide");
                                        Console.ResetColor(); Console.Write("    ");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Write($"Date de naissance :  {Day}/{Mois}/");
                                    }
                            } while (!yearValide);


                        string DateEleve = Day+"/"+Mois+"/"+Year;
                            Console.WriteLine(" ");
                            Console.WriteLine("");
                            Console.Write("    ");
                            Console.WriteLine("LISTE DES PROMOTIONS");
                            Console.WriteLine(" ");
                            Promortion promortion = new Promortion();
                            promortion.CheckPromo();


                            Console.WriteLine();
                            Console.Write("    ");
                            Console.Write("Promotion :");
                            Console.Write("    ");
                              
                            string PromotionEleve = Console.ReadLine() ?? "";
                            bool outW = false;

                            do {

                                if (PromotionEleve == "2010-2014" || PromotionEleve == "2014-2018" || PromotionEleve == "2018-2022")
                                {

                                    application.AjouterEleve(NomEleve, PrenomEleve, DateEleve, PromotionEleve);
                                    outW = true;
                                } else
                                {
                                    Console.Write("    ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("La promotion n'existe pas");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("    ");
                                    Console.Write("Promotion :");
                                    Console.Write("    ");

                                    PromotionEleve = Console.ReadLine() ?? "";
                                    if (PromotionEleve == "2010-2014" || PromotionEleve == "2014-2018" || PromotionEleve == "2018-2022")
                                    {
                                        outW = true;
                                    }
                                    }

                            } while (!outW);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    ");
                        Console.Write("    ");
                            Console.WriteLine("La création de l'élève avec succès              ");
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
                                            bool CoursDansEleve = application.IsCoursExistInEleve(IdEleve, IdCours);
                                            if (CoursExist)
                                            {
                                                if (CoursDansEleve == false)
                                                {
                                                    while (true)
                                                    {
                                                        Console.Write("    ");
                                                        Console.Write("Note :");
                                                        Console.Write("    ");

                                                        string NoteSaisi = Console.ReadLine() ?? "";
                                                        double Note;
                                                        bool isValideNote = double.TryParse(NoteSaisi, out Note);


                                                        if (!isValideNote)
                                                        {

                                                            Console.Clear();
                                                            //while (!isValideNote) { 
                                                            Console.WriteLine(GlobalAttribute.wildStudent);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine();
                                                            Console.Write("    ");
                                                            Console.WriteLine("La note est obligatoire !");
                                                            Console.WriteLine();
                                                            Console.ResetColor();
                                                            Console.ForegroundColor = ConsoleColor.Cyan;


                                                            // }  
                                                        }
                                                        else if (isValideNote)
                                                        {
                                                            Console.Write("    ");
                                                            Console.Write("Appreciation :");
                                                            Console.Write("    ");
                                                            string Appreciation = Console.ReadLine() ?? "";
                                                            Console.Write("    ");


                                                            Eleve ResultEleve = application.CheckEleveName(IdEleve);
                                                            Cours ResultCours = application.CheckCoursName(IdCours);

                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine(GlobalAttribute.wildStudent);
                                                            Console.WriteLine("");
                                                            Console.Write("    ");
                                                            Console.WriteLine($" RECAPITILATIF : ");
                                                            Console.WriteLine("");
                                                            Console.Write("          ");
                                                            Console.WriteLine($"IDENTIFIANT         :    {ResultEleve.Identifiant}     ");
                                                            Console.Write("          ");
                                                            Console.WriteLine($"NOM                 :    {ResultEleve.Nom}  ");
                                                            Console.Write("          ");
                                                            Console.WriteLine($"PRENOM              :    {ResultEleve.Prenom} ");
                                                            Console.WriteLine("    ");
                                                            Console.Write("          ");
                                                            Console.WriteLine($"COURS AJOUTEE       :    {ResultCours.Identifiant} | {ResultCours.Nom} ");
                                                            Console.WriteLine();
                                                            Console.Write("    ");
                                                            Console.WriteLine($"NOTE              : {Note} ");
                                                            Console.WriteLine("");
                                                            Console.Write("    ");
                                                            Console.WriteLine($"APPRECIATION      : {Appreciation} ");
                                                            Console.WriteLine("");
                                                            Console.WriteLine();
                                                            Console.WriteLine("    ██████████████████████████████████████████████████████████████████████████████████████████████████████████");
                                                            
                                                            Console.ForegroundColor= ConsoleColor.Red;
                                                            Console.WriteLine(" ");
                                                            Console.Write("   ");
                                                            
                                                            Console.Write(" Confirmez-vous cette action ? ");
                                                            Console.ResetColor();
                                                          //  Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.Write("Oui ");
                                                            
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("ou ");
                                                            Console.ResetColor();
                                                           // Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.Write("Non ");
                                                            Console.ResetColor();

                                                            Console.Write(" :   ");
                                                            string input = Console.ReadLine();
                                                            
                                                            if ( input.ToLower() == "oui" )
                                                            { 
                                                            application.AjouterNotePourEleve(IdEleve, IdCours, Note, Appreciation);
                                                                Console.WriteLine(" ");
                                                                Console.ForegroundColor = ConsoleColor.Green;
                                                                Console.WriteLine();
                                                                Console.Write("    ");
                                                                Console.WriteLine("La note ajoutée !");
                                                                Console.ResetColor();
                                                                Console.ReadLine();
                                                                break;
                                                                

                                                            } else
                                                            {
                                                                
                                                                Console.WriteLine(" ");
                                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                                Console.WriteLine();
                                                                Console.Write("    ");
                                                                Console.WriteLine("Vous avez abandonné !");
                                                                Console.ResetColor();
                                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                                Console.ReadLine();
                                                                break;

                                                            }
                                                        }
                                                    }
                                                } else if (CoursDansEleve == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine();
                                                    Console.Write("    ");
                                                    Console.WriteLine("Cet élève dispose déjà de ce cours !");
                                                    Console.ResetColor();
                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                    Console.ReadLine();

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
                                    Console.WriteLine("Choisissez le bon Menu !");
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
                        
                        Console.WriteLine("    ");
                        Console.Write("    ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Choisissez le bon menu");
                            Console.ResetColor();
                        Console.WriteLine("    ");
                             Console.ReadLine();

                    }
                    }
                } else if (ChoixMenuPrincipal == "3")
                {
                    while (true)
                    {


                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.Write("    ");
                        Console.WriteLine("                       MENU PROMOTION               ");
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine("[1] 2010 - 2014 ");
                        Console.Write("    ");
                        Console.WriteLine("[2] 2014 - 2018 ");
                        Console.Write("    ");
                        Console.WriteLine("[3] 2018 - 2022 ");
                        Console.Write("    ");
                        Console.WriteLine("[4] RETOUR ");

                        string PromotionChoix = "";
                        Console.Write("    ");
                        PromotionChoix = Console.ReadLine();

                        if (PromotionChoix == "1")
                        {
                            while (true)
                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(GlobalAttribute.wildStudent);
                                Console.Write("    ");
                                Console.WriteLine("                        PROMOTION               ");
                                Console.WriteLine("    ");
                                Console.Write("    ");
                                Console.WriteLine("[1] LISTER LA PROMOTION 2010 - 2014 ");
                                Console.Write("    ");
                                Console.WriteLine("[2] MOYENNE PROMOTION 2010 - 2014 ");
                                Console.Write("    ");
                                Console.WriteLine("[3] RETOUR ");
                                string optionChoice_1 = Console.ReadLine();

                                if (optionChoice_1 == "1")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(GlobalAttribute.wildStudent);
                                    Console.Write("    ");
                                    Console.WriteLine("                       PROMOTION 2010-2014               ");
                                    Console.WriteLine("");
                                    application._ListerPromotion("2010-2014");
                                    Console.Write("    ");
                                    Console.ReadLine();

                                }
                                else if (optionChoice_1 == "2")
                                {

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(GlobalAttribute.wildStudent);
                                    Console.Write("    ");
                                    Console.WriteLine("                       MOYENNE PROMOTION 2010-2014               ");
                                    Console.WriteLine("    ");
                                    Console.Write("    ");
                                    Console.ReadLine();
                                } else if (optionChoice_1 == "3")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("    ");
                                    Console.Write("    ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Vous avez saissi une mauvaise option !");
                                    Console.ResetColor();
                                    PromotionChoix = Console.ReadLine();
                                }

                            }

                        }
                        else if (PromotionChoix == "2")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(GlobalAttribute.wildStudent);
                                Console.Write("    ");
                                Console.WriteLine("                       PROMOTION               ");
                                Console.WriteLine("    ");
                                Console.Write("    ");
                                Console.WriteLine("[1] LISTER LA PROMOTION 2014 - 2018 ");
                                Console.Write("    ");
                                Console.WriteLine("[2] MOYENNE PROMOTION 2014 - 2018 ");
                                Console.Write("    ");
                                Console.WriteLine("[3] RETOUR ");
                                string optionChoice_2 = Console.ReadLine();

                                if (optionChoice_2 == "1")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(GlobalAttribute.wildStudent);
                                    Console.Write("    ");
                                    Console.WriteLine("                       PROMOTION 2014-2018               ");
                                    Console.WriteLine("");
                                    application._ListerPromotion("2014-2018");
                                    Console.Write("    ");
                                    Console.ReadLine();

                                }
                                else if (optionChoice_2 == "2")
                                {

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(GlobalAttribute.wildStudent);
                                    Console.Write("    ");
                                    Console.WriteLine("                       MOYENNE PROMOTION 2014-2018               ");
                                    Console.WriteLine("");

                                    Console.Write("    ");
                                    Console.ReadLine();
                                }
                                else if (optionChoice_2 == "3")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("    ");
                                    Console.Write("    ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Vous avez saissi une mauvaise option !");
                                    Console.ResetColor();
                                }
                            }
                        }
                        else if (PromotionChoix == "3")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(GlobalAttribute.wildStudent);
                                Console.Write("    ");
                                Console.WriteLine("                       PROMOTION               ");
                                Console.WriteLine("    ");
                                Console.Write("    ");
                                Console.WriteLine("[1] LISTER LA PROMOTION 2018 - 2022 ");
                                Console.Write("    ");
                                Console.WriteLine("[2] MOYENNE PROMOTION 2018 - 2022 ");
                                Console.Write("    ");
                                Console.WriteLine("[3] RETOUR ");
                                Console.Write("    ");
                                string optionChoice_3 = Console.ReadLine();

                                if (optionChoice_3 == "1")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(GlobalAttribute.wildStudent);
                                    Console.WriteLine("    ");
                                    Console.WriteLine("                       PROMOTION 2018-2022               ");

                                    Console.WriteLine("    ");
                                    application._ListerPromotion("2018-2022");
                                    Console.Write("    ");
                                    Console.ReadLine();

                                }
                                else if (optionChoice_3 == "2")
                                {

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(GlobalAttribute.wildStudent);
                                    Console.Write("    ");
                                    Console.WriteLine("                       MOYENNE PROMOTION 2018-2022               ");
                                    Console.WriteLine("    ");

                                    Console.ReadLine();
                                }
                                else if (optionChoice_3 == "3")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("    ");
                                    Console.Write("    ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Vous avez saissi une mauvaise option !");
                                    Console.ResetColor();
                                    PromotionChoix = Console.ReadLine();
                                }
                            }
                        } else if (PromotionChoix == "4")
                        {
                            break;
                        }
                        else
                        {

                            Console.WriteLine("    ");
                            Console.Write("    ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Vous avez saissi une mauvaise option !");
                            Console.ResetColor();

                            Console.ReadLine();

                        }
                    }
                }
                else
                {

                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Vous avez saissi une mauvaise option !");
                    Console.ResetColor();
                    Console.ReadLine();
                    
              }   
           }
        }
    }
}
