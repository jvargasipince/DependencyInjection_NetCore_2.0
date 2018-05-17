using DependencyInjection.Entities;
using System.Collections.Generic;

namespace DependencyInjection.Interface
{
    public interface IEmpleadoServices
    {

        List<Empleado> GetEmpleados();

    }
}
