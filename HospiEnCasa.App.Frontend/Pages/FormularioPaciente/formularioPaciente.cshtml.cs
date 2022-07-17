using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend
{
    public class formularioPacienteModel : PageModel
    {
     private readonly IRepositorioPaciente repositorioPaciente;
     [BindProperty]
     public Paciente Paciente {get;set;}

     public formularioPacienteModel(IRepositorioPaciente repositorioPaciente)
     {
        this.repositorioPaciente=repositorioPaciente;
     }   

        public IActionResult OnGet(int? pacienteId)
        {
            if(pacienteId.HasValue)
            {
                Paciente = repositorioPaciente.GetPaciente(pacienteId.Value);
            }
            else
            {
                Paciente=new Paciente();
            }

            if(Paciente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if(Paciente.Id>0)
            {
                Paciente=repositorioPaciente.UpdatePaciente(Paciente);
            }
            else
            {
                repositorioPaciente.AddPaciente(Paciente);
            }
            return Page();
        }
    }
}
