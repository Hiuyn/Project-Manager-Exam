using System;
using System.Threading;
using System.Threading.Tasks;

namespace FukushiKei.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();

        void SetCommandTimeout(int? timeout);
    }
}
