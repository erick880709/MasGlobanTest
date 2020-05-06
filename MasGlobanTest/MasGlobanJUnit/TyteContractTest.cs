using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaGloban.Modelo.Service.Facade;
using MaGloban.Modelo.Business.Entities.Dto;
using System.Collections.Generic;

namespace MasGlobanJUnit
{
    [TestClass]
    public class TyteContractTest
    {
        Facade facade = new Facade();
        [TestMethod]
        public void TestTypeContract()
        {
            List<TypeContractDTO> listaTipoContratos = new List<TypeContractDTO>();
            listaTipoContratos = facade.ConsultTypeContract();

            Assert.IsNotNull(listaTipoContratos);
        }

       
    } 
    
}
