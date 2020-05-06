using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaGloban.Modelo.Business.Entities.Dto;
using MaGloban.Modelo.ResourceAccess.Dao;

namespace MaGloban.Modelo.Business.Logic.EmployeesBL
{
    public class TypeContractBL
    {
        private String strerror;

        public String Error
        {
            get { return strerror; }
            set { strerror = value; }
        }
        public List<TypeContractDTO> ConsultTypeContract()
        {
            TypeContractDao objDao = new TypeContractDao();
            var respuestaDao = objDao.ConsultTypeContract();
            return respuestaDao;
        }
    }
}
