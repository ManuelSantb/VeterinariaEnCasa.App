using System.Collections.Generic;
using VeterinariaEnCasa.App.Dominio;
using System;
using System.Linq;

namespace VeterinariaEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IrepositorioMascota
    {
        ///Referencia al contexto de Mascota
        private readonly VeterinariaEnCasa.App.Persistencia.AppContext _appContext;
        ///Metodo constructor utiliza 
        ///Inyección de dependencias para indicar el contexto a utilizar 
        public RepositorioPaciente(VeterinariaEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext = appContext;
        }
        Mascota IrepositorioMascota.AddMascota(Mascota mascota)
        {
            var MascotaAdicionada = _appContext.mascotas.Add(mascota);
            _appContext.SaveChanges();
            return MascotaAdicionada.Entity;
        }

        Mascota IrepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var MascotaEncontrada= _appContext.mascotas.FirstOrDefault(p => p.id ==mascota.id);
            if(MascotaEncontrada !=null)
            {
                MascotaEncontrada.nombre=mascota.nombre;
                MascotaEncontrada.direccion=mascota.direccion;
                MascotaEncontrada.ciudad=mascota.ciudad;
                MascotaEncontrada.latitud=mascota.latitud;
                MascotaEncontrada.longitud=mascota.longitud;
                MascotaEncontrada.tipo_mascota=mascota.tipo_mascota;
                MascotaEncontrada.raza=mascota.raza;
                MascotaEncontrada.peso=mascota.peso;

                _appContext.SaveChanges();
            }
            return MascotaEncontrada;
        }
        void IrepositorioMascota.DeleteMascota(int idMascota)
        {
            var MascotaEncontrada = _appContext.mascotas.FirstOrDefault(p => p.id == idMascota);
            if (MascotaEncontrada == null)
                return;
            _appContext.mascotas.Remove(MascotaEncontrada);
            _appContext.SaveChanges();
        }
        Mascota IrepositorioMascota.GetMascota(int idMascota)
        {
            var MascotaEncontrada = _appContext.mascotas.FirstOrDefault(p=> p.id==idMascota);
            return MascotaEncontrada;
        }
        
        IEnumerable<Mascota> IrepositorioMascota.GetAllMascotas()
        {
            return _appContext.mascotas;
        }
    }
}