using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using Dominio;
using Persistencia.Interfaces;
using Persistencia.Repositorios;
using Persistencia;

namespace Aplicacion
{
    class Program
    {
        private static IEmpleadoRepository empleadosRepository = new EmpleadoRepository(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var empleadoCreado = CrearEmpleado();
            //Console.WriteLine(empleadoCreado.Nombre);

            /*
            var empleados = ObtenerEmpleados();
            foreach(var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
            */
            
            var empleadoPorId = ObtenerEmpleado();
            Console.WriteLine(empleadoPorId.Nombre);
        }

        private static Empleado CrearEmpleado()
        {
            var nuevoEmpleado = new Empleado()
            {
                Nombre = "Paula Betancourt",
                Salario = 1400000,
                Documento = "15423695",
                FechaDeNacimiento = DateTime.Now.AddYears(-19)
            };
            return empleadosRepository.AddEmpleado(nuevoEmpleado);
        }

        private static List<string> ObtenerEmpleados()
        {
            List<string> listaEmpleados = new List<string>();
            var empleados = empleadosRepository.GetAllEmpleado();

            foreach (var empleado in empleados)
            {
                listaEmpleados.Add(empleado.Nombre + " " + empleado.Salario);
            }
            return listaEmpleados;

        }

        private static Empleado ObtenerEmpleado()
        {
            
            var empleado = empleadosRepository.GetEmpleado(2);

            return empleado;
        }
    }
}
