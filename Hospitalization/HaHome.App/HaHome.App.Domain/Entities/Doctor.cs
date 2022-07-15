namespace HaHome.App.Domain.Entities
{
    public class Doctor : Person
    {
        public string MedicalSpecialty { get; set; }
        public string Code { get; set; }
        public string RethusRecord { get; set; }
    }

}
