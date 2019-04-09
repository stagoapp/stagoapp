using System.Linq;
using AutoMapper;
using WebAPI.Data.Dtos;
using WebAPI.Data.Models;

namespace WebAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<AccountDto, Account>();

            CreateMap<Contact, ContactDto>();
            CreateMap<ContactDto, Contact>();

            CreateMap<Entity, Dto>();
            CreateMap<Dto, Entity>();

            CreateMap<MessageCreationDto, Message>().ReverseMap();
            CreateMap<Message, MessageReturnDto>();
                // .ForMember(m => m.SenderPhotoUrl, opt => opt
                //     .MapFrom(u => u.Sender.Photos.FirstOrDefault(p => p.IsMain).Url))
                // .ForMember(m => m.RecipientPhotoUrl, opt => opt
                //     .MapFrom(u => u.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url));
            CreateMap<Message, MessageDto>();
            CreateMap<MessageDto, Message>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            
            CreateMap<OrderPackage, OrderPackageDto>();
            CreateMap<OrderPackageDto, OrderPackage>();
            
            CreateMap<Photo, PhotosDetailsDto>();
            CreateMap<Photo, PhotoReturnDto>();
            CreateMap<PhotoCreationDto, Photo>();
            CreateMap<Photo, PhotoDto>();
            CreateMap<PhotoDto, Photo>();

            CreateMap<Price, PriceDto>();
            CreateMap<PriceDto, Price>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();

            CreateMap<Service, ServiceDto>();
            CreateMap<ServiceDto, Service>();     

            CreateMap<Transaction, TransactionDto>();
            CreateMap<TransactionDto, Transaction>();       

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
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<UserForRegisterDto, User>();
            CreateMap<UserForUpdateDto, User>();
        }
    }
}