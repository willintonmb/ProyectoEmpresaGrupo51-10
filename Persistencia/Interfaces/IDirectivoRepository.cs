using Dominio;
using System.Collections.Generic;

namespace Persistencia.Interfaces
{
    public interface IDirectivoRepository
    {
         IEnumerable<Directivo> GetAllDirectivos();
        Directivo AddDirectivo(Directivo directivo);
        Directivo UpdateDirectivo(Directivo directivo);
        void DeleteDirectivo(int idDirectivo);
        Directivo GetDirectivo(int idDirectivo);
    }
}