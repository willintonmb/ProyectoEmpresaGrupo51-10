using Dominio;
using System.Collections.Generic;

namespace Persistencia.Interfaces
{
    public interface IEmpleadoRepository
    {
         IEnumerable<Empleado> GetAllEmpleado();
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int idEmpleado);
        Empleado GetEmpleado(int idEmpleado);
    }
}