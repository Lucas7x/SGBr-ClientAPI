using SGBr.Application.DTOs;

namespace SGBr.Application.Interfaces
{
    public interface IClientService
    {
        List<ClientDTO> List();
        ClientDTO Create(ClientCreateDTO clientDto);
    }
}
