using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    public class Paciente:Persona
    {
        public Historia Historia{get;set;}
        public List<SignoVital> SignosVitales{get;set;}
        public FamiliarDesignado familiarDesignado{get;set;}
        public Medico medico{get;set;}
        public Enfermera Enfermera{get;set;}
        public string Direccion{get;set;}
        public float latitud{get;set;}
        public float longitud{get;set;}
        public string Ciudad{get;set;}
        public DateTime FechaNacimiento{get;set;}

    }
}
