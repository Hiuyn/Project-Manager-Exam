using FukushiKei.Domain.SeedWork;
using PMSystem.Domain.AggregatesModel;
using System.Collections.Generic;

namespace PMSystem.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
        T GetById(int id);
        IList<T> ListAll();
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        int Count();

    }
}
