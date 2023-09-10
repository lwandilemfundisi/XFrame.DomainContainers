using XFrame.Ioc;

namespace XFrame.DomainContainers
{
    public interface IDomainContainer : IContainer
    {
        IDomainContainer AddTypes(IEnumerable<Type> types);
    }
}
