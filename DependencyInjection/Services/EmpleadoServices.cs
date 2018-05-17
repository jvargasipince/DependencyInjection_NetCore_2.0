using System.Collections.Generic;
using DependencyInjection.Entities;
using DependencyInjection.Interface;

namespace DependencyInjection.Services
{
    public class EmpleadoServices : IEmpleadoServices
    {
        public List<Empleado> GetEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();

            lista.Add(new Empleado() { Id = 1, NombreCompleto = "Jorge Vargas", DNI = "12345678" });
            lista.Add(new Empleado() { Id = 2, NombreCompleto = "Alex Hidalgo", DNI = "87654321" });

            return lista;
        }

    }
}
