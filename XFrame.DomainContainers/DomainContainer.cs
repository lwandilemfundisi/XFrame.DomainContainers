using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using XFrame.Ioc;

namespace XFrame.DomainContainers
{
    public class DomainContainer : Container, IDomainContainer
    {
        public DomainContainer(IServiceCollection serviceCollection) 
            : base(serviceCollection)
        {
        }

        public static IDomainContainer New()
            => new DomainContainer(new ServiceCollection()
            .AddLogging(b => b.AddConsole()));

        public static IDomainContainer New(IServiceCollection serviceCollection) 
            => new DomainContainer(serviceCollection);

        public IDomainContainer AddTypes(IEnumerable<Type> types)
        {
            foreach (var type in types)
            {
                _types.Add(type);
            }
            return this;
        }

        protected override void RegisterDefaults(
            IServiceCollection serviceCollection)
        {
            base.RegisterDefaults(serviceCollection);
        }
    }
}
