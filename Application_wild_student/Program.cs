using System.Drawing;
using Application_wild_student.Menu;
using Newtonsoft.Json;
using NLog;

namespace Application_wild_student
{
    public class Program
    {

        static void Main(string[] args)
        {

            MenuGestionnaire menu = new MenuGestionnaire();
            menu._MenuMngt();

           
        }
    }
}
