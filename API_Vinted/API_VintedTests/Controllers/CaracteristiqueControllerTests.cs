using Microsoft.VisualStudio.TestTools.UnitTesting;
using API_Vinted.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Vinted.Models.Repository;
using Moq;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.DataManage;
using Microsoft.AspNetCore.Mvc;


namespace API_Vinted.Controllers.Tests
{
    [TestClass()]
    public class CaracteristiqueControllerTests
    {
        private CaracteristiqueController _controller;
        private VintedDBContext _context;
        public CaracteristiqueControllerTests()
        {
            _context = new VintedDBContext();
            CaracteristiqueManager _repository = new CaracteristiqueManager(_context);
            _controller = new CaracteristiqueController(_repository);

        }
        [TestMethod()]
        public void CaracteristiqueControllerTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetAllAsyncTest()
        {
        }

        [TestMethod()]
        public async Task GetByIdAsyncTest()
        {

        }

        [TestMethod()]
        public void AddAsyncTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void UpdateAsyncTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DeleteAsyncTest()
        {
            throw new NotImplementedException();
        }
    }
}