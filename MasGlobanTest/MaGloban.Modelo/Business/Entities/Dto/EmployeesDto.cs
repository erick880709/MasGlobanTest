using System;

namespace MaGloban.Modelo.Business.Entities.Dto
{
    public class EmployeesDto
    {
        public decimal Identificacion { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public decimal Celular { get; set; }
        public String TipoContrato { get; set; }
        public decimal Salary_Contract { get; set; }

    }
}
