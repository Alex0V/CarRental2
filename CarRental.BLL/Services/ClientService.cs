using AutoMapper;
using CarRental.BLL.Interfaces.Services;
using CarRental.DAL.Interfaces.Repositories;
using CarRental.DAL.Entities;
using CarRental.BLL.DTO.Responses;
using CarRental.BLL.DTO.Requests;
using CarRental.DAL.Interfaces;

namespace CarRental.BLL.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;


        public async Task<ClientResponse> GetById(int id)
        {
            var client = await unitOfWork.ClientRepository.GetById(id);
            return mapper.Map<Client, ClientResponse>(client);
        }

        public void Insert(ClientRequest request)
        {
            var client = mapper.Map<ClientRequest, Client>(request);
            unitOfWork.ClientRepository.Insert(client);
            unitOfWork.SaveChangesAsync();
        }

        public void Update(ClientRequest request)
        {
            var client = mapper.Map<ClientRequest, Client>(request);
            unitOfWork.ClientRepository.Update(client);
            unitOfWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            unitOfWork.ClientRepository.Delete(id);
            unitOfWork.SaveChangesAsync();
        }

        public ClientService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
    }
}
