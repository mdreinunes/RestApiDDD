﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase <TEntity> where TEntity : class
    {
        void Add(TEntity obj);   
        void Update(TEntity obj);
        void Remove (TEntity obj);             
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);

    }
}
