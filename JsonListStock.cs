using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Application_wild_student
{
    public class JsonListStock
    {

        public List<Eleve> EleveData { get; set; }
        public List<Cours> CoursData { get; set; }


        public JsonListStock(List<Eleve> eleveData, List<Cours> coursData)
        {
            EleveData = eleveData ?? new List<Eleve>();
            CoursData = coursData ?? new List<Cours>();
        }

    }

}
