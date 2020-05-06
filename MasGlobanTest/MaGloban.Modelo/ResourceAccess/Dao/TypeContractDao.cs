using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaGloban.Modelo.Business.Entities;
using MaGloban.Modelo.Business.Entities.Dto;

namespace MaGloban.Modelo.ResourceAccess.Dao
{
    public class TypeContractDao
    {
        private String strerror;

        public String Error
        {
            get { return strerror; }
            set { strerror = value; }
        }
        /**
         * Este metodo se encarga de retornar todos los tipos de contrato en los que se puede vincular un empleado
         */
        public List<TypeContractDTO> ConsultTypeContract()
        {
            using (DB_MASGLOBANEntities1 en = new DB_MASGLOBANEntities1())
            {
                try
                {
                    var listTypeContract = (from p in en.SP_TYPE_CONTRACT()
                                         select new TypeContractDTO()
                                         {
                                             TipyContract = p.TIPOCONTRATO,
                                             
                                         }
                                       ).ToList();
                    if (listTypeContract == null)
                    {
                        listTypeContract = new List<TypeContractDTO>();
                    }
                    return listTypeContract;
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
