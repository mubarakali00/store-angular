﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Repository
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();
    }
}
