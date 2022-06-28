using AutoMapper;
using MyDotNet6ConsoleApp.AutoMapper;
using MyLibrary_DotNETstd_2_1;

namespace MyDotNet6ConsoleApp
{
    internal class AutoMapperProgram : IProgram
    {
        public void Run()
        {
            var source = new SourceType()
            {
                MyProperty = "my prop",
                SourceProperty = "source prop"
            };

            var config = AutoMapperConfig.ConfigMatchNames();

            DestinationType destinationA = MappingA(source, config);

            DestinationType destinationB = MappingB(source, config);

            WriteLine($"A: {destinationA.MyProperty}, {destinationA.DestinationProperty}");
            WriteLine($"B: {destinationB.MyProperty}, {destinationB.DestinationProperty}");

        }


        private static DestinationType MappingA(SourceType source, MapperConfiguration config)
        {
            IMapper? iMapper = config.CreateMapper();
            DestinationType? mapped = iMapper.Map<DestinationType>(source);
            //DestinationType? destT = iMapper.Map<DestinationType>(typeof(SourceType));
            return mapped;
        }
        private static DestinationType MappingB(SourceType source, MapperConfiguration config)
        {
            Mapper? mapper = new Mapper(config);
            DestinationType? mapped = mapper.Map<DestinationType>(source);

            return mapped;
        }
    }
}
