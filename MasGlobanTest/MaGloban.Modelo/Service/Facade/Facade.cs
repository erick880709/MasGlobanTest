using MaGloban.Modelo.Business.Entities.Dto;
using MaGloban.Modelo.Business.Logic.EmployeesBL;

using System;
using System.Collections.Generic;

namespace MaGloban.Modelo.Service.Facade
{
    public class Facade
    {
        private String strerror;
        public String Error
        {
            get { return strerror; }
            set { strerror = value; }
        }

        #region Emploeyees
        /**
         * METODO DE CONSULTA DE EMPLEADOS Y CALCULO DE SALARIO
         */
        public List<EmployeesDto> ConsultEmployees(int cedula, int indicador)
        {
            EmployeesBL objBl = new EmployeesBL();
            var respuestaBl = objBl.ConsultEmployees(cedula, indicador);
            return respuestaBl;
        }
        /**
         * METODO DE CONSULTA DE TIPOS DE CONTRATO
         */
        public List<TypeContractDTO> ConsultTypeContract()
        {
            TypeContractBL objBl = new TypeContractBL();
            var respuestaBL = objBl.ConsultTypeContract();
            return respuestaBL;
        }

        #endregion

    }
}
