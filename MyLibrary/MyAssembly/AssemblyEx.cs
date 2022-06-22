using MyLibrary_DotNETstd_2_1.BetterOOP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibrary_DotNETstd_2_1.MyAssembly
{
    internal class AssemblyEx : IExample
    {
        public void Execute()
        {
            IEnumerable<Type> T =
                from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                from assemblyTypes in domainAssembly.GetTypes()
                where typeof(_LandVehicle).IsAssignableFrom(assemblyTypes)
                select assemblyTypes;

            IEnumerable<Type> TT = typeof(_LandVehicle).Assembly
                .GetTypes()
                .Where(t => typeof(_LandVehicle).IsAssignableFrom(t));
        }
    }
}
