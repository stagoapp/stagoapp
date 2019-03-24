using System;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get;  }
        void Commit();
    }
}