﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTheBook.Core.GenericReporsitory
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int obj);
    }
}
