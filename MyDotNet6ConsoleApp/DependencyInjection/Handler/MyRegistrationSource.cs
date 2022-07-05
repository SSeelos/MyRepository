using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;

namespace MyDotNet6ConsoleApp.DependencyInjection.Handler
{
    public class MyRegistrationSource : IRegistrationSource
    {
        public bool IsAdapterForIndividualComponents => false;

        public IEnumerable<IComponentRegistration> RegistrationsFor(Service service, Func<Service, IEnumerable<ServiceRegistration>> registrationAccessor)
        {
            var myService = service as IServiceWithType;
            if (myService == null || !typeof(_Handler).IsAssignableFrom(myService.ServiceType))
            {
                //no request for base handler -> skip
                return Enumerable.Empty<IComponentRegistration>();
            }

            var registration = new ComponentRegistration(
                Guid.NewGuid(),
                new DelegateActivator(myService.ServiceType,
                (ctx, param) =>
                {
                    //the factory is beeing registered with Autofact
                    //-> we can just resolve here (you could hard code the factoy here)
                    var factory = ctx.Resolve<IHandlerFactory>();

                    //must use reflection, since the factory interface is generic
                    var createMethod = factory.GetType().GetMethod("CreateHandler").MakeGenericMethod(myService.ServiceType);

                    return createMethod.Invoke(factory, null);
                }),
                new CurrentScopeLifetime(),
                InstanceSharing.None,
                InstanceOwnership.OwnedByLifetimeScope,
                new[] { service },
                new Dictionary<string, object>()
                );

            return new IComponentRegistration[] { registration };
        }
    }
}
