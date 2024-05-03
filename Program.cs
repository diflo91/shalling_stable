using Application_wild_student.Menu;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application_wild_student
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            

           /*
            GlobalAttribute.logger.WriteLog("Chargement ...");

            char fillChar = '█';

            string[] lines = new string[]
            {
                "███████╗██╗  ██╗ █████╗ ██╗     ██╗     ██╗███╗   ██╗ ██████╗",
                "██╔════╝██║  ██║██╔══██╗██║     ██║     ██║████╗  ██║██╔════╝",
                "███████╗███████║███████║██║     ██║     ██║██╔██╗ ██║██║  ███╗",
                "╚════██║██╔══██║██╔══██║██║     ██║     ██║██║╚██╗██║██║   ██║",
                "███████║██║  ██║██║  ██║███████╗███████╗██║██║ ╚████║╚██████╔╝",
                "╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝"
            };
         
            int progressBarWidth = lines.Max(line => line.Length);
            int totalDuration = 10000; 
            int delay = totalDuration / progressBarWidth;

            int centerRow = Console.WindowHeight / 2;
            int centerColumn = (Console.WindowWidth - progressBarWidth) / 2;

            for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {

                Console.SetCursorPosition(centerColumn, centerRow + lineIndex);
                Console.WriteLine(lines[lineIndex]);
            }

            int progressBarRow = centerRow + lines.Length;

            List<string> cheminsFichiers = new List<string>
            {
                "D:\\Docu\\Sha\\debug\\MonFichierJson.json",
                "D:\\Proj\\visual_s\\Shallin\\Rapport.docx",
                "D:\\visual_stu\\Sha\\bin-ex\\shalling.exe",
                "D:\\Musiques\\Shal\\bi\\MonFichierLog.log",
                "D:\\Téléchar\\Sha\\C\\MonFichierJson.json",
                "D:\\Travai\\Shl\\o\\bin\\Présentation.pptx"
            };

  
            Random random = new Random();

            for (int i = 0; i <= progressBarWidth; i++)
            {
               
                int percentage = (int)((double)i / progressBarWidth * 100);

             
                Console.SetCursorPosition(centerColumn, progressBarRow + 2);
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(new string(fillChar, i));
                Console.ResetColor();
                Console.Write(new string(' ', progressBarWidth - i));
                Console.Write("");
                Console.Write($" {percentage}%");

              
                int index = random.Next(cheminsFichiers.Count);
                string cheminFichier = cheminsFichiers[index];

                Console.SetCursorPosition(centerColumn, progressBarRow + 3);
                Console.Write($"Chargement des fichiers : {cheminFichier}   "); 

 
                await Task.Delay(delay);
            }*/
            

            GlobalAttribute.logger.WriteLog("L'application a démarrée.");
            MenuGestionnaire menu = new MenuGestionnaire();
            menu._MenuMngt();
        }
    }
}
