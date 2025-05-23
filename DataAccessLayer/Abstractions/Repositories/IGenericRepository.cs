﻿using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstractions.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid key);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    } 
}
