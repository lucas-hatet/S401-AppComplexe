using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using API_Vinted.Models.Repository;
using Microsoft.AspNetCore.Mvc;
namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchatController : BaseController<Achat>
    {
        private readonly DataManager<Achat> dataRepository; 

        public AchatController(DataManager<Achat> repository)
            : base(repository)
        {
            dataRepository = repository;
        }
    }
}
