using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student
{
    public class Promortion
    {

        public List<string> _PromotionExistant { get; private set; } = new List<string>();
        



        public Promortion() 
        {
            _PromotionExistant = new List<string> {
                                                   "2010-2014",
                                                   "2014-2018",
                                                   "2018-2022"
                                                   };
        }


        public void CheckPromo()
        {
            foreach(var item in _PromotionExistant)
            {
                Console.Write("    ");
                Console.WriteLine(item);
            }
        }


    }
}
