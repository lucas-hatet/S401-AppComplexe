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
    public class ArticleControllerTests
    {
        private ArticleController _controller;
        private VintedDBContext _context;
        public ArticleControllerTests()
        {
            _context = new VintedDBContext();
            ArticleManager _repository = new ArticleManager(_context);
            _controller = new ArticleController(_repository);
        }
        [TestMethod()]
        public void ArticleControllerTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetAllAsyncTest()
        {
            throw new NotImplementedException();

        }

        [TestMethod()]
        public async Task GetByIdAsyncTest()
        {
            int id = 1;
            Article articleDB = _context.Articles.FirstOrDefault(a => a.IDArticle == id);
            var articleController = await _controller.GetByIdAsync(id);


            Assert.IsInstanceOfType(articleController, typeof(ActionResult<Article>));
            Assert.IsInstanceOfType(articleController.Result, typeof(OkObjectResult));

            var okResult = (OkObjectResult)articleController.Result;


            var article = okResult.Value as Article;

            Assert.IsNotNull(article);

            Assert.AreEqual(article, articleDB);
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