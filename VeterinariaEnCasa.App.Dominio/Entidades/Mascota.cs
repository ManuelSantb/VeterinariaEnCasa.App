using System;

namespace VeterinariaEnCasa.App.Dominio
{
    public class Mascota
    {
        public int id{get;set;}
        public string nombre {get;set;}
        public string direccion {get;set;}
        public string ciudad {get;set;}
        public float latitud {get;set;}
        public float longitud {get;set;}
        public string tipo_mascota{get;set;}
        public string raza {get;set;}
        public float peso {get;set;}
    }
}