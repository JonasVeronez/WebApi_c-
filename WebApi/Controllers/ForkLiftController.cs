using forklift.Repository;
using forkLift.Model;
using Microsoft.AspNetCore.Mvc;

namespace forkLift.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForkLiftController : ControllerBase
    {
        public IForkLiftRepository _repository;
        public ForkLiftController(IForkLiftRepository repository)
        {
            _repository = repository;
            
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok();
        }
        [HttpPost]
        public  async Task<IActionResult> Post( ForkLift forkLift)
        {
            _repository.AdicionaForkLift(forkLift);
            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário Adicionado com sucesso")
                    : BadRequest("Erro ao Salvar Usuário");
        }
    }
}