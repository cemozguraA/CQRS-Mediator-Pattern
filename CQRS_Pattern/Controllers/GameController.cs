using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using DAL.CQRS.Quires.Request;
using DAL.CQRS.Quires.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ApiBaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetAllGameRequest requestModel)
        {
            List<GetAllGameResponse> games = await Mediator.Send(requestModel);
            return Ok(games);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> Get([FromQuery] GetByIdGameRequest requestModel)
        {
            GetByIdGameResponse product = await Mediator.Send(requestModel);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateGameRequest requestModel)
        {
            CreateGameResponse response = await Mediator.Send(requestModel);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateGameRequest requestModel)
        {
            UpdateGameResponse response = await Mediator.Send(requestModel);
            return Ok(response);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteGameRequest requestModel)
        {
            DeleteGameResponse response = await Mediator.Send(requestModel);
            return Ok(response);
        }
        
    }
}
