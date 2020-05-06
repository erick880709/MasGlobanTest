using MaGloban.Modelo.Business.Entities.Dto;
using MaGloban.Modelo.Service.Facade;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MasGloban.Services.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {
        public String mensaje;
        Facade obj = new Facade();

        [HttpGet]
        [Route("GetEmployees")]
        public IEnumerable<EmployeesDto> GetEmployesses(int cedula, int indicador)
        {
            if (cedula.ToString() is null)
            {
                cedula = 0;
            }
            if (indicador.ToString() is null)
            {
                indicador = 0;
            }
            List<EmployeesDto> respuesta = new List<EmployeesDto>();
            respuesta = obj.ConsultEmployees(cedula, indicador);
            return respuesta;
        }

        [HttpGet]
        [Route("GetTypecontract")]
        public IEnumerable<TypeContractDTO> GetTypeContract()
        {
            List<TypeContractDTO> respuesta = new List<TypeContractDTO>();
            respuesta = obj.ConsultTypeContract();
            return respuesta;
        }

    }
}
