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
    public class ReviewController : Controller
    {
        private readonly ILogger<ReviewController> _logger;

        private IUnitOfWork _unitofWork;
        private IReviewService _reviewService;
        CarRentalDBContext _db;

        public ReviewController(ILogger<ReviewController> logger, IUnitOfWork unitofWork, IReviewService reviewService, CarRentalDBContext db)
        {
            _logger = logger;
            _unitofWork = unitofWork;
            _reviewService = reviewService;
            _db = db;
        }

        [HttpGet("GetReviewByID")]
        public async Task<ActionResult<Review>> GetReviewByID(int id)
        {
            return Ok(await _unitofWork.ReviewRepository.GetById(id));
        }

        [HttpGet("GetAllReview")]
        public async Task<ActionResult<Review>> GetAllReview()
        {
            return Ok(await _unitofWork.ReviewRepository.GetAll());
        }

        [HttpGet("GetAllReviewPaging")]
        public async Task<ActionResult<Review>> GetAllReviewPaging([FromQuery] ReviewParameters reviewParameters)
        {
            return Ok(await _unitofWork.ReviewRepository.GetReviews(reviewParameters));
        }
    }
}
