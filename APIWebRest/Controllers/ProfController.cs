using Microsoft.AspNetCore.Mvc;

namespace APIWebRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfController:ControllerBase
    {
        private readonly ILogger<ProfController> _logger;

        public ProfController(ILogger<ProfController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Prof> Get()
        {
            return ProfDAO.getAll();
        }

        [HttpGet("{id}")]
        public Prof GetById(int id)
        {
            return ProfDAO.getById(id);

        }


        /*[HttpGet("{id}/{login}")]
        public User GetByLogin(int id, string login)
        {
            return UserDAO.getByIdLogin(id, login);

        }*/

        [HttpPost]
        public void Post(Prof prof)
        {
            ProfDAO.InsertProf(prof);
        }


        [HttpDelete("{prof}")]
        public void Delete(Prof prof)
        {
            ProfDAO.DeleteProf(prof);
        }
    }
}
