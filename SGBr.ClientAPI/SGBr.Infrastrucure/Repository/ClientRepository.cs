using SGBr.Application.Interfaces;
using SGBr.Domain.Entities;
using SGBr.Infrastrucure.Database;

namespace SGBr.Infrastrucure.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public Client Create(Client client)
        {
            _context.Clients.Add(client);

            return client;
        }

        public List<Client> List()
        {
            var clients = _context.Clients.AsQueryable();
            return clients.ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
