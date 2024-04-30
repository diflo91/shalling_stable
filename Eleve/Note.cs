using System;

public class Note
{
    public Cours Cours { get; set; }
    public double Valeur { get; set; }
    public string Appreciation { get; set; }

    public Note(Cours cours, double valeur, string appreciation)
    {
        Cours = cours;
        Valeur = valeur;
        Appreciation = appreciation;
    }

    public override string ToString()
    {
        string view = $@"
                                        Cour : {Cours.Nom} 
                                        Note : {Valeur}/20
                                        Appréciation : {Appreciation}
                        ";
        return view;
    }
}
