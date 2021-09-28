using System.Collections.Generic;
using Dominio;
using Persistencia;
using Persistencia.Interfaces;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class DirectivoRepository : IDirectivoRepository
    {
        private readonly AppContext _appContext;

        public DirectivoRepository(AppContext appContext)
        {
            _appContext = appContext;
        }
        Directivo IDirectivoRepository.AddDirectivo(Directivo directivo)
        {
            var directivoAdicionado = _appContext.Directivos.Add(directivo);
            _appContext.SaveChanges();
            return directivoAdicionado.Entity;
        }

        void IDirectivoRepository.DeleteDirectivo(int idDirectivo)
        {
            var directivoEncontrado = _appContext.Directivos.FirstOrDefault(x => x.Id == idDirectivo);
            
            if (directivoEncontrado == null)
                return;

            _appContext.Directivos.Remove(directivoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Directivo> IDirectivoRepository.GetAllDirectivos()
        {
            return _appContext.Directivos;
        }

        Directivo IDirectivoRepository.GetDirectivo(int idDirectivo)
        {
            return _appContext.Directivos.FirstOrDefault(x => x.Id == idDirectivo);
        }

        Directivo IDirectivoRepository.UpdateDirectivo(Directivo directivo)
        {
            var directivoEncontrado = _appContext.Directivos.FirstOrDefault(x => x.Id == directivo.Id);

            if (directivoEncontrado != null)
            {
                directivoEncontrado.Nombre = directivo.Nombre;
                directivoEncontrado.Documento = directivo.Documento;
                directivoEncontrado.Categoria = directivo.Categoria;
                directivoEncontrado.fechaDeNacimiento = directivo.fechaDeNacimiento;
                directivoEncontrado.Salario = directivo.Salario;
                _appContext.SaveChanges();
            }

            return directivoEncontrado;
        }
    }
}