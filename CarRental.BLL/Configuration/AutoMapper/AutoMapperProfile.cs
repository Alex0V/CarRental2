using AutoMapper;
using CarRental.BLL.DTO.Requests;
using CarRental.BLL.DTO.Responses;
using CarRental.DAL.Entities;


namespace CarRental.BLL.Configuration.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        private void CreateClientMaps()
        {
            CreateMap<Client, ClientResponse>();

            CreateMap<ClientRequest, Client>();
        }
        private void CreateReviewMaps()
        {
            CreateMap<Review, ReviewResponse>()
                .ForMember(dest => dest.CarID, opt => opt.MapFrom(src => src.CarID))
                .ForMember(dest => dest.ClientID, opt => opt.MapFrom(src => src.ClientID))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                .ForMember(dest => dest.TextReviews, opt => opt.MapFrom(src => $"{src.TextReviews} ++++ {src.Rating}"));
                
            CreateMap<ReviewRequest, Review>();
        }

        public AutoMapperProfile()
        {
            CreateClientMaps();
            CreateReviewMaps();
        }

    }
}
