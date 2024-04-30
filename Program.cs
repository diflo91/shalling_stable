using System.Drawing;
using Application_wild_student.Menu;
using ConsoleApp1;
using Newtonsoft.Json;


namespace Application_wild_student
{
    public class Program
    {
       
        static async Task Main(string[] args)
        {
            
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

            int totalDuration = 5000;
            int delay = totalDuration / progressBarWidth;

            int centerRow = Console.WindowHeight / 2;
            int centerColumn = (Console.WindowWidth - progressBarWidth) / 2;
            for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {
                Console.SetCursorPosition(centerColumn, centerRow + lineIndex);
                Console.WriteLine(lines[lineIndex]);
            }
            int progressBarRow = centerRow + lines.Length;
            for (int i = 0; i <= progressBarWidth; i++)
            {
                int percentage = (int)((double)i / progressBarWidth * 100);
                Console.SetCursorPosition(centerColumn, progressBarRow);
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(new string(fillChar, i));
                Console.ResetColor();
                Console.Write(new string(' ', progressBarWidth - i));
                Console.Write("]");
                Console.Write($" {percentage}%");
                await Task.Delay(delay);
            }

            Console.SetCursorPosition(centerColumn, progressBarRow + 2);
            Console.WriteLine("Chargement terminé !");



            GlobalAttribute.logger.WriteLog("L'application a demarrée.");
            MenuGestionnaire menu = new MenuGestionnaire();
            menu._MenuMngt();

           
        }
    }
}
