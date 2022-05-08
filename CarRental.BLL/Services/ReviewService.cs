using AutoMapper;
using CarRental.BLL.Interfaces.Services;
using CarRental.DAL.Interfaces.Repositories;
using CarRental.DAL.Entities;
using CarRental.DAL.Interfaces.Repositories.Base;
using CarRental.BLL.DTO.Responses;
using CarRental.BLL.DTO.Requests;
using CarRental.DAL.Interfaces;

namespace CarRental.BLL.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        private readonly IReviewRepository reviewRepository;

        public async Task<IEnumerable<ReviewResponse>> GetAll()
        {
            var review = await reviewRepository.GetAll();
            return mapper.Map<List<ReviewResponse>>(review);
        }
        public async Task<ReviewResponse> GetById(int id)
        {
            var review = await reviewRepository.GetById(id);
            return mapper.Map<ReviewResponse>(review);
        }

        public void Insert(ReviewRequest request)
        {
            var review = mapper.Map<Review>(request);
            reviewRepository.Insert(review);
            unitOfWork.SaveChangesAsync();
        }

        public void Update(ReviewRequest request)
        {
            var review = mapper.Map<Review>(request);
            reviewRepository.Update(review);
            unitOfWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            reviewRepository.Delete(id);
            unitOfWork.SaveChangesAsync();
        }

        public ReviewService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            reviewRepository = this.unitOfWork.ReviewRepository;
        }
    }
}
