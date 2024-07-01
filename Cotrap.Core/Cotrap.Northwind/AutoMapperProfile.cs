
using AutoMapper;

namespace Cotrap.Northwind;

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
    }
}
