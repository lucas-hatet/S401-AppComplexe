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
    public class CaracteristiqueArticleControllerTests
    {
        private CaracteristiqueArticleController _controller;
        private VintedDBContext _context;
        public CaracteristiqueArticleControllerTests()
        {
            _context = new VintedDBContext();
            CaracteristiqueArticleManager _repository = new CaracteristiqueArticleManager(_context);
            _controller = new CaracteristiqueArticleController(_repository);

        }
        [TestMethod()]
        public void CaracteristiqueArticleControllerTest()
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
            // Arrange
            int idArticle = 1;
            int idCaracteristique = 1;
            CaracteristiqueArticle caracteristiqueArticleDB = _context.CaracteristiqueArticles.FirstOrDefault(
                ca => ca.IDArticle == idArticle && ca.IDCaracteristique == idCaracteristique);

            var controllerResult = await _controller.GetByIdAsync(idArticle, idCaracteristique);

            Assert.IsInstanceOfType(controllerResult, typeof(ActionResult<CaracteristiqueArticle>));
            Assert.IsInstanceOfType(controllerResult.Result, typeof(OkObjectResult));

            var okResult = (OkObjectResult)controllerResult.Result;
            Assert.IsInstanceOfType(okResult.Value, typeof(ActionResult<CaracteristiqueArticle>));

            var caracteristiqueArticle = (CaracteristiqueArticle)okResult.Value;

            Assert.AreEqual(caracteristiqueArticle.IDArticle, caracteristiqueArticleDB.IDArticle);
            Assert.AreEqual(caracteristiqueArticle.IDCaracteristique, caracteristiqueArticleDB.IDCaracteristique);
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