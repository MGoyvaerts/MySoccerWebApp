using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MySoccerWebApp.Interfaces.Repositories
{
    //public interface IBaseRepository<T> : IDisposable
    //{
    //    #region methods
    //    IQueryable<T> FindAll();
    //    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    //    void Create(T entity);
    //    void Update(T entity);
    //    void Delete(T entity);
    //    #endregion
    //}

    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
