using NTier.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NTier.Data.Service
{
    public interface IRepository<T> where T : Table
    {
        List<T> Get();
        List<A> Get<A>() where A : Table;
        List<T> GetWhere(Expression<Func<T, bool>> predicate);
        List<A> GetWhere<A>(Expression<Func<A, bool>> predicate) where A : Table;
        T GetSingle(Func<T, bool> predicate);
        A GetSingle<A>(Func<A, bool> predicate) where A : Table;
        T GetById(long id);
        A GetById<A>(long id) where A : Table;
        bool Add(T entity);
        bool Add<A>(A entity) where A : Table;
        bool Remove(T entity);
        bool Remove<A>(A entity) where A : Table;
        bool Remove(long id);
        bool Remove<A>(long id) where A : Table;
        bool Update(T entity, long id);
        bool Update<A>(A entity, long id) where A : Table;
        int Save();
        void BeginTran();
        void Commit();
        void Rollback();
    }
}
