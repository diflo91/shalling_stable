namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    public class CandyManager
    {
        // Liste pour stocker les noms de bonbons
        private List<string> candies;

        // Constructeur de la classe
        public CandyManager()
        {
            candies = new List<string>();
        }

        // Méthode pour ajouter un nom de bonbon à la liste
        public void AddCandy(string candyName)
        {
            candies.Add(candyName);
            Console.WriteLine($"{candyName} a été ajouté à la liste.");
        }

        // Méthode pour afficher tous les noms de bonbons dans la liste
        public void DisplayCandies()
        {
            Console.WriteLine("Liste des bonbons :");
            foreach (var candy in candies)
            {
                Console.WriteLine(candy);
            }
        }
    }

    // Exemples d'utilisation de la classe CandyManager
    public class Program
    {
        public static void Main()
        {
            // Créer une instance de CandyManager
            CandyManager manager = new CandyManager();

            // Demander à l'utilisateur de saisir des noms de bonbons
            Console.WriteLine("Entrez les noms de bonbons (saisissez 'stop' pour arrêter) :");

            while (true)
            {
                Console.Write("Nom de bonbon : ");
                string candyName = Console.ReadLine();

                // Si l'utilisateur saisit 'stop', on arrête la boucle
                if (candyName.ToLower() == "stop")
                {
                    break;
                }

                // Ajouter le nom de bonbon à la liste
                manager.AddCandy(candyName);
            }

            // Afficher la liste des bonbons
            manager.DisplayCandies();
        }
    }

}
