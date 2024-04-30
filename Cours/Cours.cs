using System;

public class Cours
{
    public int Identifiant { get; set; }
    public string Nom { get; set; }

    public Cours(int identifiant, string nom)
    {
        Identifiant = identifiant;
        Nom = nom;
    
    }

    public override string ToString()
    {
        return $"ID: {Identifiant}, Nom: {Nom}";
    }
}
