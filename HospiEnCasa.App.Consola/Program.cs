using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{

    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Pepito",
                Apellidos = "Perex Prieto",
                Telefono = "300000",
                Genero = Genero.masculino,
                Direccion = "Calle 8",
                longitud = 45.5F,
                latitud = 5.8F,
                Ciudad = "Santa Marta",
                FechaNacimiento = new DateTime(1972, 08, 22),

            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}
