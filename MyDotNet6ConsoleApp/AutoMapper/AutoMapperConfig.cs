using AutoMapper;

namespace MyDotNet6ConsoleApp.AutoMapper
{
    //Configuration should only happen once per AppDomain.
    //(on application startup)
    public static class AutoMapperConfig
    {
        public static MapperConfiguration Config()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SourceType, DestinationType>());
            // var config = new MapperConfiguration(cfg => cfg.CreateMap(typeof(SourceType), typeof(DestinationType)));

            return config;
        }
        public static MapperConfiguration ConfigMatchNames()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SourceType, DestinationType>()
            .ForMember("DestinationProperty", memeberConfig => memeberConfig.MapFrom(sourceType => sourceType.SourceProperty)));

            return config;
        }
        public static MapperConfiguration ConfigMatchInterface()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ISourceType, DestinationType>()
            .ForMember("DestinationProperty", memeberConfig => memeberConfig.MapFrom(sourceType => sourceType.SourceProperty)));

            return config;
        }
    }
}
