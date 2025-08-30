using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        // Com o Mediatr
        [HttpPost("create")]
        public Task<CreateCustomerResponse> Create(
            [FromServices]IMediator mediator, // Injeção de dependência via parâmetro
            [FromBody] CreateCustomerRequest command // Dados do cliente via body
            )
        {
            return mediator.Send(command); // Retorna o resultado do handler
        }

        // Sem o Mediatr
        //[HttpPost("create")]
        //public CreateCustomerResponse Create(
        //    [FromServices]ICreateCustomerHandler handler, // Injeção de dependência via parâmetro
        //    [FromBody]CreateCustomerRequest command // Dados do cliente via body
        //    )
        //{
        //    return handler.Handle(command); // Retorna o resultado do handler
        //}
    }
}
