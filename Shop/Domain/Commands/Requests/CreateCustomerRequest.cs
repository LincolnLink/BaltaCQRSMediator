using MediatR;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Requests{

    //Com o MediartR tem que por o IRequest<CreateCustomerResponse>
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    { 
        public string Name { get; set; }

        public string Email { get; set; }
    }
}