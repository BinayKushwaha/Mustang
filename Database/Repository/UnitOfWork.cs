using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Mustang.Database.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.Database.Repository
{
    public class UnitOfWork : BaseRepository, IUnitOfWork
    {
        private bool _IsDisposed = false;

        public UnitOfWork(ApplicationContext applicationContext) : base(applicationContext)
        {

        }
        public async Task<IDbContextTransaction> BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            return await DataContext.Database.BeginTransactionAsync(isolationLevel);
        }

        public async Task<int> CommitAsync()
        {
            if (_IsDisposed)
                throw new ObjectDisposedException(this.GetType().FullName);
            return await DataContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_IsDisposed) return;

            if (disposing && DataContext != null)
            {
                DataContext.Dispose();
            }
            _IsDisposed = true;
        }
    }
}
