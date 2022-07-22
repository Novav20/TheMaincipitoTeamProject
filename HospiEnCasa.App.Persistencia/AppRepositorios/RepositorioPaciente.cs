using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
               {return;} 
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }
        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.latitud = paciente.latitud;
                pacienteEncontrado.longitud = paciente.longitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.familiarDesignado = paciente.familiarDesignado;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.medico = paciente.medico;
                pacienteEncontrado.Historia = paciente.Historia;
                
                _appContext.SaveChanges();

            }
            return pacienteEncontrado;
        }
         Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;
        }
        FamiliarDesignado IRepositorioPaciente.AsignarFamiliarDesignado(int idPaciente, int idFamiliarDesignado)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var familiarDesignadoEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(m => m.Id == idFamiliarDesignado);
                if (familiarDesignadoEncontrado != null)
                {
                    pacienteEncontrado.familiarDesignado = familiarDesignadoEncontrado;
                    _appContext.SaveChanges();
                }
                return familiarDesignadoEncontrado;
            }
            return null;
        }
        Enfermera IRepositorioPaciente.AsignarEnfermera(int idPaciente, int idEnfermera)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var enfermeraEncontrado = _appContext.Enfermeras.FirstOrDefault(m => m.Id == idEnfermera);
                if (enfermeraEncontrado != null)
                {
                    pacienteEncontrado.Enfermera = enfermeraEncontrado;
                    _appContext.SaveChanges();
                }
                return enfermeraEncontrado;
            }
            return null;
        }
        Historia IRepositorioPaciente.AsignarHistoria(int idPaciente, int idHistoria)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var historiaEncontrada = _appContext.Historias.FirstOrDefault(m => m.Id == idHistoria);
                if (historiaEncontrada != null)
                {
                    pacienteEncontrado.Historia = historiaEncontrada;
                    _appContext.SaveChanges();
                }
                return historiaEncontrada;
            }
            return null;
        }
    }
}
