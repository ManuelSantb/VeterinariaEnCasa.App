using System.Collections.Generic;
using System;
using VeterinariaEnCasa.App.Dominio;
using VeterinariaEnCasa.App.Persistencia;

namespace VeterinariaEnCasa.App.Consola
{
    class Program
    {
        private static IrepositorioMascota _RepoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba CRUD");
            //AddMascota();
            //BuscarMascota(1);
        }
        private static void AddMascota()
        {
            var Mascota = new Mascota

            {
                nombre = "Tony",
                direccion = "cll 15",
                ciudad = "Manizales",
                latitud = 1126255,
                longitud = 16542351F,
                tipo_mascota = "perro",
                raza = "Pastor Aleman",
                peso = 300,

            };
            _RepoPaciente.AddMascota(Mascota);
        }
        private static void BuscarMascota(int idMascota)
        {
            var mascota = _RepoPaciente.GetMascota(idMascota);
            Console.WriteLine(mascota.nombre + " "+mascota.raza);
        
        }
}
}

