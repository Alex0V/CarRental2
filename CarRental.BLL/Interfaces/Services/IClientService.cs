using CarRental.BLL.DTO.Requests;
using CarRental.BLL.DTO.Responses;

namespace CarRental.BLL.Interfaces.Services
{

    public interface IClientService
    {
        Task<ClientResponse> GetById(int id);
        void Insert(ClientRequest request);
        void Update(ClientRequest request);
        void Delete(int id);
    }

}