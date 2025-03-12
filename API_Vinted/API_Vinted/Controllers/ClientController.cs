using API_Vinted.Models.DataManage;
using API_Vinted.Models.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace API_Vinted.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : BaseController<Client>
    {
        private readonly DataManager<Client> dataRepository;

        public ClientController(DataManager<Client> repository)
            : base(repository)
        {
            dataRepository = repository;
        }
    }
}
