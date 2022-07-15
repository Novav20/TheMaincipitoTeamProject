namespace HaHome.App.Domain.Entities
{
    public class Nurse : Person
    {
        public string ProfessionalCard { get; set; }
        public int WorkingHours { get; set; }
    }
}