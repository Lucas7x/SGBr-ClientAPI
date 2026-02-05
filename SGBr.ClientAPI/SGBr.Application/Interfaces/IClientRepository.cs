using SGBr.Domain.Entities;

namespace SGBr.Application.Interfaces
{
    public interface IClientRepository
    {
        Client Create(Client client);
        List<Client> List();
        void SaveChanges();
    }
}
