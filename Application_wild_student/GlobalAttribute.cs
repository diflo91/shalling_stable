using NLog;
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

        public static string MonCheminJson = "MonFichierJson.json";
        public static Dictionary<int, Dictionary<string, string>> ListeDeNote { get; set; }

 






    }

}
