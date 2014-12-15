﻿using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace Arquitetura.Data.GenericRepositoryInterfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> GetQuery();
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> where);
        T Single(Func<T, bool> where);
        T First(Func<T, bool> where);
        void Delete(T entity);
        void Add(T entity);
        void Attach(T entity);
        void Update(T entity);
        void SaveChanges();
        void SaveChanges(SaveOptions saveOptions);
    }
}
