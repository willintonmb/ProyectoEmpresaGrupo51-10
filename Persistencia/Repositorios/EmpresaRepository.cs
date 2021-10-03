using System.Collections.Generic;
using Dominio;
using Persistencia;
using Persistencia.Interfaces;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly AppContext _appContext;

        public EmpresaRepository(AppContext appContext)
        {
            _appContext = appContext;
        }
        Empresa IEmpresaRepository.AddEmpresa(Empresa empresa)
        {
            var empresaAdicionado = _appContext.Empresas.Add(empresa);
            _appContext.SaveChanges();
            return empresaAdicionado.Entity;
        }

        void IEmpresaRepository.DeleteEmpresa(int idEmpresa)
        {
            var empresaEncontrado = _appContext.Empresas.FirstOrDefault(x => x.Id == idEmpresa);
            
            if (empresaEncontrado == null)
                return;

            _appContext.Empresas.Remove(empresaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Empresa> IEmpresaRepository.GetAllEmpresa()
        {
            return _appContext.Empresas;
        }

        Empresa IEmpresaRepository.GetEmpresa(int idEmpresa)
        {
            return _appContext.Empresas.FirstOrDefault(x => x.Id == idEmpresa);
        }

        Empresa IEmpresaRepository.UpdateEmpresa(Empresa empresa)
        {
            var empresaEncontrado = _appContext.Empresas.FirstOrDefault(x => x.Id == empresa.Id);

            if (empresaEncontrado != null)
            {
                empresaEncontrado.Nombre = empresa.Nombre;
                empresaEncontrado.Nit = empresa.Nit;
                _appContext.SaveChanges();
            }

            return empresaEncontrado;
        }
    }
}