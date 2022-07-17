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
    public class Medico_FormularioModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        [BindProperty]
        public Medico Medico {get;set;}
        public Medico_FormularioModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public IActionResult OnGet(int? medicoId)
        {
            if(medicoId.HasValue)
            {
                Medico = repositorioMedico.GetMedico(medicoId.Value);
            }
            else
            {
                Medico = new Medico();
            }
            if(Medico==null)
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
            if(Medico.Id>0)
            {
            Medico=repositorioMedico.UpdateMedico(Medico);
            }
            else
            {
                repositorioMedico.AddMedico(Medico);
            }
            return Page();
        }
    }
}
