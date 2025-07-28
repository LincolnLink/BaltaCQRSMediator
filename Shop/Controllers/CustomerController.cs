using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;

namespace Shop.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CreateCustomerResponse Create(
            [FromServices]ICreateCustomerHandler handler,
            [FromBody]CreateCustomerRequest command
            )
        {
            return handler.Handle(command);
        }
    }
}
