using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    public class GestionApplication
    {
        private List<Eleve> eleves = new List<Eleve>();
        private List<Cours> cours = new List<Cours>();
        public void AjouterEleve(int identifiant, string nom, string prenom, string dateDeNaissance)
        {
            Eleve nouvelEleve = new Eleve(identifiant, nom, prenom, dateDeNaissance);
            eleves.Add(nouvelEleve);
            Console.WriteLine($"Élève ajouté : {nouvelEleve}");
        }

        
        public void AjouterCours(int identifiant, string nom)
        {
            Cours nouveauCours = new Cours(identifiant, nom);
            cours.Add(nouveauCours);
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

        public void AjouterNotePourEleve(int identifiantEleve, int identifiantCours, double valeur, string appreciation)
        {
            Eleve eleve = eleves.Find(e => e.Identifiant == identifiantEleve);
            Cours courses = cours.Find(c => c.Identifiant == identifiantCours);

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
                Console.WriteLine($"\nInformations de l'élève avec ID {identifiant} :");
                Console.WriteLine(eleve);


                Console.WriteLine("\nCours inscrits :");
                foreach (var c in eleve.ListeCours)
                {
                    Console.WriteLine($"- {c}");
                }

 
                Console.WriteLine("\nNotes et appréciations :");
                foreach (var n in eleve.ListeNotes)
                {
                    Console.WriteLine($"- {n}");
                }
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
                Console.WriteLine(eleve.Nom);
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
