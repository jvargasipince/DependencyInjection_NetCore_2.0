using DependencyInjection.Entities;
using DependencyInjection.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DependencyInjection.Controllers
{
    [Produces("application/json")]
    [Route("api/Empleado")]
    public class EmpleadoController : Controller
    {

        IEmpleadoServices _empleadoServices; 

        public EmpleadoController(IEmpleadoServices empleadoServices)
        {
            _empleadoServices = empleadoServices;
        }

        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return _empleadoServices.GetEmpleados();
        }


    }
}