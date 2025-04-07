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
    public class AdresseControllerTests
    {
        private AdresseController _controller;
        private VintedDBContext _context;
        public AdresseControllerTests() { 
            _context = new VintedDBContext();
            AdresseManager _repository = new AdresseManager(_context);
            _controller = new AdresseController(_repository);
        
        }
        [TestMethod()]
        public void AdresseControllerTest()
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
            int id = 1;
            Adresse adresseDB = _context.Adresses.FirstOrDefault(a => a.IDAdresse == id);
            var adresseController =   await _controller.GetByIdAsync(id);

            Assert.IsInstanceOfType(adresseController, typeof(OkObjectResult));
            Assert.IsInstanceOfType(adresseController.Value, typeof(Adresse));

            Assert.AreEqual(adresseController.Value, adresseDB);

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