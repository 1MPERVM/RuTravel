using AutoMapper;
using RuTravel.Domain;
using RuTravel.WebApi.DTO;


namespace RuTravel.WebApi.Mapping
{
    public class RuTravelProfile : Profile
    {
        public RuTravelProfile()
        {
            CreateMap<Cafes, CafeReadDto>().ReverseMap();

            CreateMap<Comments, CommentReadDto>().ReverseMap();
            CreateMap<CommentCreateDto, Comments>().ReverseMap();

            CreateMap<Flats, FlatReadDto>().ReverseMap();

            CreateMap<Photos, PhotoReadDto>().ReverseMap();
            CreateMap<PhotoCreateDto, Photos>().ReverseMap();

            CreateMap<Posts, PostReadDto>().ReverseMap();
            CreateMap<PostCreateDto, Posts>().ReverseMap();

            CreateMap<Sights, SightReadDto>().ReverseMap();
            CreateMap<SightCreateDto, Sights>().ReverseMap();

            CreateMap<Towns, TownReadDto>().ReverseMap();

            CreateMap<Users, UserReadDto>().ReverseMap();
            CreateMap<UserCreateDto, Users>().ReverseMap();
            CreateMap<UserUpdateDto, Users>().ReverseMap();
        }
    }
}
