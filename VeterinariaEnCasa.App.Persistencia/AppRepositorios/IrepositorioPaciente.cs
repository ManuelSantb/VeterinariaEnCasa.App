using System.Collections.Generic;
using VeterinariaEnCasa.App.Dominio;

namespace VeterinariaEnCasa.App.Persistencia
{
    public interface IrepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
    }
}