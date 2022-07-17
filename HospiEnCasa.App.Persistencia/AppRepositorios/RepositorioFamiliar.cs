using HospiEnCasa.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        private readonly AppContext _appContext;
        public RepositorioFamiliar(AppContext appContext)
        {
            _appContext = appContext;
        }

        FamiliarDesignado IRepositorioFamiliar.AddFamiliarDesignado(FamiliarDesignado familiar)
        {
            var familiarAdicionado = _appContext.FamiliaresDesignados.Add(familiar);
            _appContext.SaveChanges();
            return familiarAdicionado.Entity;
        }
        void IRepositorioFamiliar.DeleteFamiliarDesignado(int idFamiliarDesignado)
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
            if (familiarEncontrado == null)
                {return;}
            _appContext.FamiliaresDesignados.Remove(familiarEncontrado);
            _appContext.SaveChanges();
        }
        
         FamiliarDesignado IRepositorioFamiliar.GetFamiliarDesignado(int idFamiliarDesignado)
        {          
            return _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
        }
        FamiliarDesignado IRepositorioFamiliar.UpdateFamiliarDesignado(FamiliarDesignado familiar)  
        {
            var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == familiar.Id);
            if (familiarEncontrado != null)
            {
                familiarEncontrado.Nombre = familiar.Nombre;
                familiarEncontrado.Apellidos = familiar.Apellidos;
                familiarEncontrado.Telefono = familiar.Telefono;
                familiarEncontrado.Genero = familiar.Genero;
                familiarEncontrado.Parentesco = familiar.Parentesco;
                familiarEncontrado.Correo = familiar.Correo;
                
                _appContext.SaveChanges();
            }
            return familiarEncontrado;
        }

    }
}