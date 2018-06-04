using AutoMapper;
using GameClassification.Domain.Entities;
using GameClassification.MVC.ViewModels;

namespace GameClassification.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}