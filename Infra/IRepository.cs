using Quality.DTH;
namespace Quality.DTH
{
    public interface IRepository<T> where T: IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}