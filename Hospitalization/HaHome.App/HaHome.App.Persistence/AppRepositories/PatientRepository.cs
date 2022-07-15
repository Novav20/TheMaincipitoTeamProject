using System.Collections.Generic;
using System.Linq;
using HaHome.App.Domain.Entities;

namespace HaHome.App.Persistence.AppRepositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppContext _appContext;
        public PatientRepository(AppContext _appContext)
        {
            this._appContext = _appContext;
        }
        IEnumerable<Patient> IPatientRepository.GetAllPatients() => _appContext.Patients;
        Patient IPatientRepository.AddPatient(Patient patient)
        {
            var addedPatient = _appContext.Patients.Add(patient);

            _appContext.SaveChanges();

            return addedPatient.Entity;
        }
        Patient IPatientRepository.UpdatePatient(Patient patient)
        {
            var foundPatient = _appContext.Patients.FirstOrDefault(p => p.Id == patient.Id);

            if (foundPatient != null)
            {
                foundPatient.Name = patient.Name;
                foundPatient.Surname = patient.Surname;
                foundPatient.Cellphone = patient.Cellphone;
                foundPatient.Genre = patient.Genre;
                foundPatient.History = patient.History;
                foundPatient.Relative = patient.Relative;
                foundPatient.Nurse = patient.Nurse;
                foundPatient.Doctor = patient.Doctor;
                foundPatient.Address = patient.Address;
                foundPatient.Latitude = patient.Latitude;
                foundPatient.Longitude = patient.Longitude;
                foundPatient.City = patient.City;
                foundPatient.DateOfBirth = patient.DateOfBirth;

                _appContext.SaveChanges();
            }
            return foundPatient;
        }
        void IPatientRepository.DeletePatient(int idPatient)
        {
            var foundPatient = _appContext.Patients.FirstOrDefault(p => p.Id == idPatient);
            if (foundPatient == null) return;
            _appContext.Patients.Remove(foundPatient);
            _appContext.SaveChanges();
        }
        Patient IPatientRepository.GetPatient(int idPatient)
        => _appContext.Patients.FirstOrDefault(p => p.Id == idPatient);
    }
}