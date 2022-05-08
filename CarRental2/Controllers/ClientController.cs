using CarRental.BLL.Interfaces.Services;
using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Entities.Models;
using CarRental.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarRental2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly ILogger<ReviewController> _logger;

        private IUnitOfWork _unitofWork;
        private IClientService _clientService;
        CarRentalDBContext _db;

        public ClientController(ILogger<ReviewController> logger, IUnitOfWork unitofWork, IClientService clientService, CarRentalDBContext db)
        {
            _logger = logger;
            _unitofWork = unitofWork;
            _clientService = clientService;
            _db = db;
        }

        [HttpGet("GetAllClientPagingFiltering")]
        public async Task<ActionResult<Client>> GetAllClientPaging([FromQuery] ClientParameters clientParameters)
        {
            return Ok(await _unitofWork.ClientRepository.GetClients(clientParameters));
        }

        [HttpGet("GetAllClient")]
        public async Task<ActionResult<Client>> GetAllClient()
        {
            return Ok(await _unitofWork.ClientRepository.GetAll());
        }
    }
}
