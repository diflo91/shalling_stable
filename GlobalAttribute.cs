
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student
{
    public abstract class GlobalAttribute
    {
        
        public static string wildStudent = @"
    ███████╗██╗  ██╗ █████╗ ██╗     ██╗     ██╗███╗   ██╗ ██████╗ 
    ██╔════╝██║  ██║██╔══██╗██║     ██║     ██║████╗  ██║██╔════╝ 
    ███████╗███████║███████║██║     ██║     ██║██╔██╗ ██║██║  ███╗
    ╚════██║██╔══██║██╔══██║██║     ██║     ██║██║╚██╗██║██║   ██║
    ███████║██║  ██║██║  ██║███████╗███████╗██║██║ ╚████║╚██████╔╝
    ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                          Developped by Fleury
    ----------------------------------------------------------------------------------------------------------";

        public static string MonCheminJson = "D:\\Visual studio\\projets\\shalling-avancé\\MonFichierJson.json";
        public static string MonCheminJsonCours = "D:\\Visual studio\\projets\\shalling-avancé\\bin\\Debug\\net7.0\\MonFichierJsonCours.json";
        public static Dictionary<int, Dictionary<string, string>> ListeDeNote { get; set; }
        public static string logFilePath = "D:\\Visual studio\\projets\\shalling-avancé\\MonFichierLog.log";
        public static Logs logger = new Logs(GlobalAttribute.logFilePath);









    }

}
