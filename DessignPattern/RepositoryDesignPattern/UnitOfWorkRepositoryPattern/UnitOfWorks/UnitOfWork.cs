using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPattern.Repository;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace UnitOfWorkRepositoryPattern.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public DbContext Context { get; }
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }
        public void Dispose()
        {
            Context.Dispose();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }

}
