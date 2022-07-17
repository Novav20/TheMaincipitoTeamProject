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
    public class Lista_de_PacientesModel : PageModel
    {
        //Lista de pacientes
        private readonly IRepositorioPaciente repositorioPaciente;
        public IEnumerable<Paciente> Pacientes {get;set;}
        public Lista_de_PacientesModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente=repositorioPaciente;
        }
        public void OnGet()
        {
            Pacientes = repositorioPaciente.GetAllPacientes();
        }
    }
}
