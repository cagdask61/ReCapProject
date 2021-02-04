using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<C> where C:class , IEntity, new()
    {

        List<C> GetAll(Expression<Func<C,bool>> filter=null);
        C Get(Expression<Func<C,bool>> filter);
        void Add(C entity);
        void Delete(C entity);
        void Update(C entity);


    }
}
