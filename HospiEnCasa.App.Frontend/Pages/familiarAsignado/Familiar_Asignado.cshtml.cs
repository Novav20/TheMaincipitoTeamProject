using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace MyApp.Namespace
{
     public class Familiar_AsignadoModel : PageModel
    {
        private readonly IRepositorioFamiliar repositorioFamiliar;
        [BindProperty]
        public FamiliarDesignado FamiliarDesignado {get;set;}
        public Familiar_AsignadoModel(IRepositorioFamiliar repositorioFamiliar)
        {
            this.repositorioFamiliar = repositorioFamiliar;
        }
        public IActionResult OnGet(int? familiarId)
        {
            if(familiarId.HasValue)
            {
                FamiliarDesignado = repositorioFamiliar.GetFamiliarDesignado(familiarId.Value);
            }
            else
            {
                FamiliarDesignado = new FamiliarDesignado();
            }
            if(FamiliarDesignado==null)
            {
                return RedirectToPage(".NotFound");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if(FamiliarDesignado.Id>0)
            {
            FamiliarDesignado=repositorioFamiliar.UpdateFamiliarDesignado(FamiliarDesignado);
            }
            else
            {
                repositorioFamiliar.AddFamiliarDesignado(FamiliarDesignado);
            }
            return Page();
        }
    }
}