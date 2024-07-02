
using AutoMapper;

namespace Cotrap.API;

public class AutoMapperProfile: Profile
{

    public AutoMapperProfile()
    {
        CreateMap<Category, CategoriaDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.Descrizione, opt => opt.MapFrom(src => src.Description))
            .ReverseMap();

        CreateMap<Category, CategoriaCreaDTO>()
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.Descrizione, opt => opt.MapFrom(src => src.Description))
            .ReverseMap();

       CreateMap<Order, OrdineDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
            .ReverseMap();

        CreateMap<Order, OrdineCreaDTO>()
            .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
            .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
            .ReverseMap();    
        
        CreateMap<Customer, CustomerDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.CompanyName))
            .ForMember(dest => dest.Indirizzo, opt => opt.MapFrom(src => src.Address))
            .ForMember(dest => dest.Contatto, opt => opt.MapFrom(src => src.ContactName))
            .ReverseMap();

        CreateMap<Customer, CustomerCreaDTO>()
            .ForMember(dest => dest.Chiave, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.CompanyName))
            .ForMember(dest => dest.Indirizzo, opt => opt.MapFrom(src => src.Address))
            .ForMember(dest => dest.Contatto, opt => opt.MapFrom(src => src.ContactName))
            .ReverseMap();


    }
}
