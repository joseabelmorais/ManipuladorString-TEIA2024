using AutoMapper;
using ManipuladorString.Domain;
using ManipuladorString.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ManipuladorString.Controllers
{
    [ApiController]
    [Route("/api/manipulacao-string")]
    public class ManipuladorStringController : ControllerBase
    {

        private readonly IMapper _mapper;

        public ManipuladorStringController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult ManipularString([FromBody] string? texto)
        {

            if (texto == null || texto == String.Empty)
            {
                return BadRequest(
                    new ProblemDetails
                    {
                        Title = "Erro de input",
                        Status = 400,
                        Detail = "Texto nulo ou vázio."
                    });
            }
            return Ok(_mapper.Map<ReadManipuladorStringRespostaDto>(new ManipuladorStringResposta(texto)));
        }





    }
}
