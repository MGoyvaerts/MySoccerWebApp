using MySoccerWebApp.Infrastructure.DatabaseContext;
using MySoccerWebApp.Interfaces.Repositories;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MySoccerWebApp.Infrastructure.UnitOfWork
{
    //public interface IUnitOfWork
    //{
    //    #region Methods
    //    void Commit();
    //    #endregion
    //}
    //public interface IUnitOfWork<out TContext>
    //where TContext : DbContext, new()
    public interface IUnitOfWork
    {
        void Commit();
        void RejectChanges();
        void Dispose();
        //MySoccerWebAppDbContext Context { get; }
        //void CreateTransaction();
        //void Commit();
        //void Rollback();
        //void Save();
    }
}
