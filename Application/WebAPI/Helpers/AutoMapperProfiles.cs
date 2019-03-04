using System.Linq;
using AutoMapper;
using WebAPI.Data.Dtos;
using WebAPI.Data.Models;
using WebAPI.Data.Dtos;
using WebAPI.Data.Models;

namespace WebAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Entity, Dto>();
            CreateMap<Dto, Entity>();
            CreateMap<User, UserListDto>();
            CreateMap<User, UserListDto>();
                // .ForMember(dest => dest.PhotoUrl, opt => {
                //     opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                // });
                // .ForMember(dest => dest.Age, opt => {
                //     opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                // });
            CreateMap<User, UserDetailsDto>();
                // .ForMember(dest => dest.PhotoUrl, opt => {
                //     opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                // });
                // .ForMember(dest => dest.Age, opt => {
                //     opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                // });
            CreateMap<Photo, PhotosDetailsDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoReturnDto>();
            CreateMap<PhotoCreationDto, Photo>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<MessageCreationDto, Message>().ReverseMap();
            CreateMap<Message, MessageReturnDto>();
                // .ForMember(m => m.SenderPhotoUrl, opt => opt
                //     .MapFrom(u => u.Sender.Photos.FirstOrDefault(p => p.IsMain).Url))
                // .ForMember(m => m.RecipientPhotoUrl, opt => opt
                //     .MapFrom(u => u.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url));
        }
    }
}