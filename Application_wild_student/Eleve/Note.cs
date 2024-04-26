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
        return $"Cours: {Cours}, Note: {Valeur}, Appréciation: {Appreciation}";
    }
}
