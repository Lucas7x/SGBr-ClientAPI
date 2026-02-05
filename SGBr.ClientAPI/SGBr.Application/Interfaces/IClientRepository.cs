using SGBr.Domain.Entities;

namespace SGBr.Application.Interfaces
{
    public interface IClientRepository
    {
        Client? GetByEmail(string email);
        Client Create(Client client);
        List<Client> List();
        void SaveChanges();
    }
}
