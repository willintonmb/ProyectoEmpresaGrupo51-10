using Dominio;
using System.Collections.Generic;

namespace Persistencia.Interfaces
{
    public interface IEmpresaRepository
    {
         IEnumerable<Empresa> GetAllEmpresa();
        Empresa AddEmpresa(Empresa empresa);
        Empresa UpdateEmpresa(Empresa empresa);
        void DeleteEmpresa(int idEmpresa);
        Empresa GetEmpresa(int idEmpresa);
    }
}