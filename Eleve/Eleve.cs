using Application_wild_student;
using System;
using System.Collections.Generic;

public class Eleve
{
    public int Identifiant { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string DateDeNaissance { get; set; }
    public string Promotion { get; set; }
    public List<Cours> ListeCours { get; set; } = new List<Cours>();
    public List<Note> ListeNotes { get; set; } = new List<Note>();

    public Eleve(int identifiant, string nom, string prenom, string dateDeNaissance, string promotion)
    {
        Identifiant = identifiant;
        Nom = nom;
        Prenom = prenom;
        DateDeNaissance = dateDeNaissance;
        Promotion = promotion;

    }

    public void AjouterCours(Cours cours)
    {
        
        
            ListeCours.Add(cours);
        
    }
    
    public void SupprimerCours(Cours cours)
    {
        ListeCours.Remove(cours);
        ListeNotes.RemoveAll(n => n.Cours == cours);
    }

 
    public void AjouterNotePourCours(Cours cours, double valeur, string appreciation)
    {
   
      
            Note note = new Note(cours, valeur, appreciation);
            ListeNotes.Add(note);
     
    }

    public override string ToString()
    {
        return $"ID: {Identifiant}, Nom: {Nom}, Prénom: {Prenom}, Date de naissance: {DateDeNaissance:dd/mm/yyyy}";
    }
}
