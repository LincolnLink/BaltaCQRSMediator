using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers
{
    // Com o Mediatr
    public class CreateCustomerHandler : 
        IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere o cliente
            // Envia email de boas vindas
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Lincoln Ferreira",
                Email = "link@email.com.br",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }

    // Sem o Mediatr
    //public class CreateCustomerHandler : ICreateCustomerHandler
    //{
    //    public CreateCustomerResponse Handle(CreateCustomerRequest request)
    //    {
    //        // Verifica se o cliente já está cadastrado
    //        // Valida os dados
    //        // Insere o cliente
    //        // Envia email de boas vindas
    //        return new CreateCustomerResponse
    //        {
    //            Id = Guid.NewGuid(),
    //            Name = "Lincoln Ferreira",
    //            Email = "link@email.com.br",
    //            Date = DateTime.Now
    //        };


    //    }
    //}
}