using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student
{
    public class JsonListStock
    {
        private List<Eleve> EleveData { get; set; } = new List<Eleve>();
        private List<Cours> CoursData { get; set; } = new List<Cours>();


     public JsonListStock(List<Eleve> newEleveData, List<Cours> newCoursData)
        {
            EleveData = newEleveData;
            CoursData = newCoursData;
        }

    }
}
