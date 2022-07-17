using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioFamiliar
    {
      FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado familiar);
      FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado familiar);
      void DeleteFamiliarDesignado(int idFamiliarDesignado);
      FamiliarDesignado GetFamiliarDesignado(int idFamiliarDesignado);
      
    }
   
}