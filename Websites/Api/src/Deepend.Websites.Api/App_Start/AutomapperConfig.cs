using AutoMapper;
using Deepend.Service.Provider.Dto;
using Deepend.Services.Model;


namespace Deepend.Website.Api.App_Start
{
    public class AutomapperConfig
    {
       
        public static IMapper GetMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            var mapper = mapperConfiguration.CreateMapper();
            return mapper;
        }
    }

   
    public class MappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ChequeXml, Cheque>();
        }
    }
}