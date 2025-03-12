using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : BaseController<Achat>
    {
        private readonly DataManager<Achat> dataRepository;

        public ArticleController(DataManager<Achat> repository)
            : base(repository)
        {
            dataRepository = repository;
        }
    }
}
