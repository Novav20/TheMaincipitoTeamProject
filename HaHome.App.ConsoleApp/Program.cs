using System;
using HaHome.App.Domain.Entities;
using HaHome.App.Persistence.AppRepositories;
using AppContext = HaHome.App.Persistence.AppRepositories.AppContext;

namespace HaHome.App.ConsoleApp
{
    class Program
    {
        private static IPatientRepository _patientRepo = new PatientRepository(new AppContext());
        static void Main(string[] args)
        {
            //AddPatient();
            FindPatient(1);
        }
        private static void AddPatient()
        {
            var patient = new Patient
            {
                Name = "Veronica Alejandra",
                Surname = "Vera",
                Genre = Genre.FEMALE,
                Address = "1ro de abril, esteban echeverria",
                City = "Buenos Aires",
                Cellphone = "+54(11)3778-6148",
                DateOfBirth = new DateTime(2002, 2, 10),
                Latitude = -34.7630990,
                Longitude = -58.4901190
            };
            _patientRepo.AddPatient(patient);
        }
        private static void FindPatient(int patientId)
        {
            var patient = _patientRepo.GetPatient(patientId);
            System.Console.WriteLine($"{patient.Name} {patient.Surname}");
        }
    }
}
