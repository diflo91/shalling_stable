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
        private List<Cours> cours = new List<Cours>();


        public void _ChargerListJson()
        {
            if (File.Exists(GlobalAttribute.MonCheminJson))
            {

                string jsonData = File.ReadAllText(GlobalAttribute.MonCheminJson);
                eleves = JsonConvert.DeserializeObject<List<Eleve>>(jsonData) ?? new List<Eleve>();

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

            string JsonSave = JsonConvert.SerializeObject(eleves);
            File.WriteAllText(GlobalAttribute.MonCheminJson, JsonSave);
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

            string JsonSave = JsonConvert.SerializeObject(cours);
            File.WriteAllText(GlobalAttribute.MonCheminJson, JsonSave);

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
                Console.WriteLine($"Cours supprimé : {coursASupprimer}");
            }
            else
            {
                Console.WriteLine($"Cours avec ID {identifiant} non trouvé.");
            }
        }

        public void AjouterNotePourEleve(int identifiantEleve, string identifiantCours, double valeur, string appreciation)
        {
            Eleve eleve = eleves.Find(e => e.Identifiant == identifiantEleve);
            Cours courses = cours.Find(c => c.Nom == identifiantCours);

            if (eleve != null && cours != null)
            {
                eleve.AjouterNotePourCours(courses, valeur, appreciation);
                Console.WriteLine($"Note de {valeur} ajoutée pour l'élève {eleve.Nom} {eleve.Prenom} dans le cours {courses.Nom}.");
            }
            else
            {
                Console.WriteLine("Élève ou cours non trouvé.");
            }
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
                Console.WriteLine($"IDENTIFIANT         :      {eleve.Identifiant}");
                Console.Write("          ");
                Console.WriteLine($"NOM                 :      {eleve.Nom}");
                Console.Write("          ");
                Console.WriteLine($"PRENOM              :      {eleve.Prenom}");
                Console.Write("          ");
                Console.WriteLine($"DATE DE NAISSANCE   :      {eleve.DateDeNaissance}");
                Console.WriteLine();

                Console.Write("    ");
                Console.WriteLine("COURS INSCRITS              :");
                foreach (var c in eleve.ListeCours)
                {
                    Console.Write("                                   ");
                    Console.WriteLine($"- {c.Nom}");
                }

                Console.Write("    ");
                Console.WriteLine("NOTES ET APPRECIATIONS      :");
                foreach (var n in eleve.ListeNotes)
                {
                    Console.Write("                          ");
                    Console.WriteLine($" {n}");
                   
                } 
                    Console.WriteLine("");
                    Console.Write("    -----------------------------------------------------------------------------------------------------------");
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
        }

        public void VoirLesCours()
        {
            foreach (var coursItem in cours)
            {
                Console.WriteLine(coursItem.Nom);
            }
        }
    }

}
