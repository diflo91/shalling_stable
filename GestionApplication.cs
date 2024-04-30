using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using Application_wild_student;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class GestionApplication
    {
        private List<Eleve> eleves = new List<Eleve>();
        public List<Cours> cours = new List<Cours>();


        public void _ChargerListJson()
        {
            if (File.Exists(GlobalAttribute.MonCheminJson))
            {

                string jsonData = File.ReadAllText(GlobalAttribute.MonCheminJson);
                eleves = JsonConvert.DeserializeObject<List<Eleve>>(jsonData) ?? new List<Eleve>();

                string jsonDataCours = File.ReadAllText(GlobalAttribute.MonCheminJsonCours);
                cours = JsonConvert.DeserializeObject<List<Cours>>(jsonDataCours) ?? new List<Cours>();
                GlobalAttribute.logger.WriteLog($"les données ont bien été chargées.");
            }
        }


        public void AjouterEleve(string nom, string prenom, string dateDeNaissance)
        {

           
            int identifiant = 0;
            foreach (Eleve eleve in eleves)
            {
                identifiant = eleve.Identifiant++;
            }

            Eleve nouvelEleve = new Eleve(identifiant, nom, prenom, dateDeNaissance);
            eleves.Add(nouvelEleve);

            string JsonSave = JsonConvert.SerializeObject(eleves, Formatting.Indented);
            File.WriteAllText(GlobalAttribute.MonCheminJson, JsonSave);
            GlobalAttribute.logger.WriteLog($"L'utilisateur a ajouté l'élève {nom}.");
        }

        
        public void AjouterCours( string nom)
        {

            int identifiant = 0;
            foreach (Cours courses in cours)
            {
                identifiant = courses.Identifiant++;
            }

            Cours nouveauCours = new Cours(identifiant, nom);
            cours.Add(nouveauCours);

            string JsonSave = JsonConvert.SerializeObject(cours, Formatting.Indented);
            File.WriteAllText(GlobalAttribute.MonCheminJsonCours, JsonSave);
            GlobalAttribute.logger.WriteLog($"L'utilisateur a ajouté le cours {nom} .");

            Console.WriteLine();
            Console.Write("    ");
            Console.WriteLine($"Cours ajouté : {nouveauCours.Nom}");

            foreach (var eleve in eleves)
            {
                eleve.AjouterCours(nouveauCours);
            }

        }

  
        public void SupprimerCours(int identifiant)
        {
            Cours coursASupprimer = cours.Find(c => c.Identifiant == identifiant);
            if (coursASupprimer != null)
            {
                cours.Remove(coursASupprimer);

           
                foreach (var eleve in eleves)
                {
                    eleve.SupprimerCours(coursASupprimer);
                   
                }
                string JsonSave = JsonConvert.SerializeObject(cours);
                File.WriteAllText(GlobalAttribute.MonCheminJsonCours, JsonSave);
                GlobalAttribute.logger.WriteLog($"L'utilisateur a supprimé le cours {coursASupprimer} .");
                Console.WriteLine();
                Console.Write("    ");
                Console.WriteLine($"Cours supprimé : {coursASupprimer.Nom}");
            }
            else
            {
                Console.WriteLine($"Cours avec ID {identifiant} non trouvé.");

            }
        }

        public void AjouterNotePourEleve(int identifiantEleve, int identifiantCours, double valeur, string appreciation)
        {
            Eleve eleve = eleves.Find(e => e.Identifiant == identifiantEleve);
            Cours courses = cours.Find(c => c.Identifiant == identifiantCours);

            if (eleve != null && cours != null)
            {
                eleve.AjouterNotePourCours(courses, valeur, appreciation);

                string JsonSave = JsonConvert.SerializeObject(eleves, Formatting.Indented);
                File.WriteAllText(GlobalAttribute.MonCheminJson, JsonSave);
                GlobalAttribute.logger.WriteLog($"L'utilisateur a ajouté la note pour {courses.Nom} à {eleve.Nom} .");

            }
            else
            {
                Console.WriteLine("Élève ou cours non trouvé.");
            }
        }

        public bool CheckEleveExist(int identifiantCkeck)
        {

            Eleve eleve = eleves.Find(e => e.Identifiant == identifiantCkeck);
            return eleve != null;
        }

        public bool CheckCoursExist(int identifiantCkeckCours)
        {

            Cours courses = cours.Find(c => c.Identifiant == identifiantCkeckCours);
            return courses != null;
        }


        public void AfficherEleve(int identifiant)
        {
            Eleve eleve = eleves.Find(e => e.Identifiant == identifiant);
            if (eleve != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(GlobalAttribute.wildStudent);
                Console.WriteLine("");
                Console.Write("    ");
                Console.WriteLine($"INFORMATION DE L'ELEVE :");
                Console.WriteLine("");
                Console.Write("          ");
                Console.WriteLine($"NOM                 :      {eleve.Nom}");
                Console.Write("          ");
                Console.WriteLine($"PRENOM              :      {eleve.Prenom}");
                Console.Write("          ");
                Console.WriteLine($"DATE DE NAISSANCE   :      {eleve.DateDeNaissance}");
                Console.WriteLine();

                Console.Write("    ");
                Console.WriteLine("RESULTATS SCOLAIRE      :");

                double total = 0;
                int count = 0;
                foreach (var n in eleve.ListeNotes)
                {
                    Console.Write("                          ");
                    Console.WriteLine($" {n}");
                    total += n.Valeur;
                    count++;
                }
                
                double moyenne = Math.Round(total / count);

                Console.WriteLine("");
                Console.Write("    -----------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("    ");
                    Console.WriteLine($"MOYENNE :  {moyenne }  ");
                    Console.Write("    -----------------------------------------------------------------------------------------------------------");

                    GlobalAttribute.logger.WriteLog($"L'utilisateur a consulté l'élève {eleve.Nom}.");
            }
            else
            {
                Console.WriteLine($"Aucun élève trouvé avec l'ID {identifiant}.");
            }
        }

        public void VoirLesEleves()
        {
            foreach (var eleve in eleves)
            { 
               
                Console.Write("    ");
                Console.Write(eleve.Identifiant);
                Console.Write("    ");
                Console.Write(eleve.Nom);
                Console.Write("    ");
                Console.WriteLine(eleve.Prenom);
                

            }
            GlobalAttribute.logger.WriteLog($"L'utilisateur a consulté la liste des élève.");
        }

        public void VoirLesCours()
        {
          if (cours.Count != 0) { 
            foreach (var coursItem in cours)
            {

                    Console.Write("    ");
                    Console.Write(coursItem.Identifiant);
                    Console.Write("    ");
                    Console.WriteLine(coursItem.Nom);
                   

                }
                 GlobalAttribute.logger.WriteLog($"L'utilisateur a consulté la liste des cours.");
                } else if ((cours.Count == 0))

                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Write("    ");
                    Console.WriteLine("Aucun cours n'est disponible !");
                    Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;

            }
            
        }
    }

}
