using CarRental.BLL.DTO.Requests;
using CarRental.BLL.DTO.Responses;

namespace CarRental.BLL.Interfaces.Services
{

    public interface IReviewService
    {
        Task<IEnumerable<ReviewResponse>> GetAll();
        Task<ReviewResponse> GetById(int id);
        void Insert(ReviewRequest request);
        void Update(ReviewRequest request);
        void Delete(int id);
    }

}