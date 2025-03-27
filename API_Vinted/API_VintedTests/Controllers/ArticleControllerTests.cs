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

namespace API_Vinted.Controllers.Tests
{
    [TestClass()]
    public class ArticleControllerTests
    {
        [TestMethod()]
        public void ArticleControllerTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetAllAsyncTest()
        {
            //var mockRepository = new Mock<IDataRepository<Article>>();
            //var articleController = new ArticleController(mockRepository.Object);
            //Article testArticle = new Article();

            //var result = articleController.GetAllAsync();


            //Assert.AreEqual(result.GetType(),typeof(List<Article>));
        }

        [TestMethod()]
        public void GetByIdAsyncTest()
        {
            throw new NotImplementedException();
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