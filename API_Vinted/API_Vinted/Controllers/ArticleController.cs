using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : BaseController<Article>
    {
        private readonly DataManager<Article> dataRepository;

        public ArticleController(DataManager<Article> repository)
            : base(repository)
        {
            dataRepository = repository;
        }
    }
}
