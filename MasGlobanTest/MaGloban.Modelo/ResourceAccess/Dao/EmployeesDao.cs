using MaGloban.Modelo.Business.Entities;
using MaGloban.Modelo.Business.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MaGloban.Modelo.ResourceAccess.Dao
{
    public class EmployeesDao
    {
        private String strerror;

        public String Error
        {
            get { return strerror; }
            set { strerror = value; }
        }


        /**
         * Metodo encargado de retornar los empleados con el calculo de su salario
         * La responsabilidad del calculo por temas de seguriad esta delegado al Procedimiento almacenado
         * tipop de retorno employeesDto es un objeto con la respuesta del prc
         */
        public List<EmployeesDto> ConsultEmployees(int cedula, int indicador)
        {
            using (DB_MASGLOBANEntities1 en = new DB_MASGLOBANEntities1())
            {
                try
                {
                    var listEmployees = (from p in en.SP_CONSULT_EMPLOYEES(cedula, indicador)
                                         select new EmployeesDto()
                                         {
                                             Identificacion = p.IDENTIFICACION.Value,
                                             Nombre = p.NOMBRE,
                                             Apellido = p.APELLIDO,
                                             Celular = p.CELULAR.Value,
                                             TipoContrato = p.TIPOCONTRATO,
                                             Salary_Contract = p.SALARY_CONTRACT.Value
                                         }
                                       ).ToList();
                    if (listEmployees == null)
                    {
                        listEmployees = new List<EmployeesDto>();
                    }
                    return listEmployees;
                }
                catch (Exception ex)
                {
                    strerror = ex.Message + "." + (ex.InnerException != null ? ex.InnerException.ToString() : "") + "" + ex.StackTrace;
                    return null;
                }
            }
        }

    }
}
