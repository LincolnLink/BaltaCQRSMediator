using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere o cliente
            // Envia email de boas vindas
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Lincoln Ferreira",
                Email = "link@email.com.br",
                Date = DateTime.Now
            };


        }
    }
}