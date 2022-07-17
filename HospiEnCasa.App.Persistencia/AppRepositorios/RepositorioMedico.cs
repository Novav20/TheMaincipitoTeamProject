using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        public RepositorioMedico(AppContext appContext)
        {
            _appContext = appContext;
        }

        Medico IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }
        void IRepositorioMedico.DeleteMedico(int idMedico)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
            if (medicoEncontrado == null)
                {return;}
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
       Medico IRepositorioMedico.GetMedico(int idMedico)
        {          
            return _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
        }
        
        Medico IRepositorioMedico.UpdateMedico(Medico medico)  
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == medico.Id);
            if (medicoEncontrado != null)
            {
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellidos = medico.Apellidos;
                medicoEncontrado.Telefono = medico.Telefono;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.Codigo = medico.Codigo;
                medicoEncontrado.Registro_Rethus = medico.Registro_Rethus;
               
                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }

    }
}