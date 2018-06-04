using AutoMapper;
using GameClassification.MVC.AutoMapper;

namespace GameClassification.MVC
{
    public class AutoMapperConfig
    {

        public static void RegisterMappings()
        {

            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });

        }
    }
}