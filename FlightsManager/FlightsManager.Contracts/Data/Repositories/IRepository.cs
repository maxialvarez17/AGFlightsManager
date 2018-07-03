using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Contracts.Data.Repositories
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);
    }
}