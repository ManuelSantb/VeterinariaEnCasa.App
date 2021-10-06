using System;

namespace VeterinariaEnCasa.App.Dominio
{
    public class Persona
    {
        public int id {get;set;}
        public string nombre{get;set;}
        public string apellidos{get;set;}
        public string numeroTelefono {get;set;}
        public Genero genero{get;set;}
    }
}