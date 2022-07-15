using System.Collections.Generic;

namespace HaHome.App.Domain.Entities
{
    public class History
    {
        public int Id { get; set; }
        public List<CareSuggestion> Suggestions { get; set; }
        public string Diagnosis { get; set; }
        public string Enviroment { get; set; }
    }

}

