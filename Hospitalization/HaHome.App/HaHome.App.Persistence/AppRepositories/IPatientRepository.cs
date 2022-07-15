using System.Collections.Generic;
using HaHome.App.Domain.Entities;

namespace HaHome.App.Persistence.AppRepositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetAllPatients();
        Patient AddPatient(Patient patient);
        Patient UpdatePatient(Patient patient);
        void DeletePatient(int idPatient);
        Patient GetPatient(int idPatient);
    }
}

