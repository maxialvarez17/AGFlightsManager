using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightsManager.Contracts.Data.Repositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        ICollection<TEntity> GetAll();

        TEntity Get(int id);
    }
}