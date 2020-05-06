using MaGloban.Modelo.Business.Entities.Dto;
using MaGloban.Modelo.ResourceAccess.Dao;
using System;
using System.Collections.Generic;

namespace MaGloban.Modelo.Business.Logic.EmployeesBL
{
    public class EmployeesBL
    {
        private String strerror;

        public String Error
        {
            get { return strerror; }
            set { strerror = value; }
        }
        /**
         * Metodo que conecta la cada de datos del Dao con la facade con el fin de ser alcanzada por los proyectos que
         * utilicen a masGlobanmodelo como referencia
         */
        public List<EmployeesDto> ConsultEmployees(int cedula, int indicador)
        {
            EmployeesDao objDao = new EmployeesDao();
            var respuestaDao = objDao.ConsultEmployees(cedula, indicador);
            return respuestaDao;
        }
    }
}
