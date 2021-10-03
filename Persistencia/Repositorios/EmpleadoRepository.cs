using System.Collections.Generic;
using Dominio;
using Persistencia;
using Persistencia.Interfaces;
using System.Linq;

namespace Persistencia.Repositorios
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly AppContext _appContext;

        public EmpleadoRepository(AppContext appContext)
        {
            _appContext = appContext;
        }
        Empleado IEmpleadoRepository.AddEmpleado(Empleado empleado)
        {
            var empleadoAdicionado = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }

        void IEmpleadoRepository.DeleteEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(x => x.Id == idEmpleado);
            
            if (empleadoEncontrado == null)
                return;

            _appContext.Empleados.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Empleado> IEmpleadoRepository.GetAllEmpleado()
        {
            return _appContext.Empleados;
        }

        Empleado IEmpleadoRepository.GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(x => x.Id == idEmpleado);
        }

        Empleado IEmpleadoRepository.UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(x => x.Id == empleado.Id);

            if (empleadoEncontrado != null)
            {
                empleadoEncontrado.Nombre = empleado.Nombre;
                empleadoEncontrado.Documento = empleado.Documento;
                empleadoEncontrado.FechaDeNacimiento = empleado.FechaDeNacimiento;
                empleadoEncontrado.Salario = empleado.Salario;
                _appContext.SaveChanges();
            }

            return empleadoEncontrado;
        }
    }
}