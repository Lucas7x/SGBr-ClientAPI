using SGBr.Domain.Entities;

namespace SGBr.Application.Interfaces
{
    public interface IClientRepository
    {
        Client Create(Client user);
        List<Client> List();
        void SaveChanges();
    }
}
