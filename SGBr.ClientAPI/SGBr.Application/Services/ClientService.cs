using SGBr.Application.DTOs;
using SGBr.Application.Interfaces;
using SGBr.Domain.Entities;

namespace SGBr.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public ClientDTO Create(ClientCreateDTO clientDto)
        {
            Client? client = _clientRepository.GetByEmail(clientDto.Email);
            if (client == null)
                throw new ArgumentException("O E-mail informado já está sendo utilizado");

            client = new Client
            {
                Name = clientDto.Name,
                Email = clientDto.Email,
            };

            _clientRepository.Create(client);
            _clientRepository.SaveChanges();

            return new ClientDTO
            {
                Id = client.Id,
                Name = client.Name,
                Email = client.Email
            };
        }

        public List<ClientDTO> List()
        {
            List<Client> clients = _clientRepository.List();

            return clients.Select(c => new ClientDTO
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email
            }).ToList();
        }
    }
}
