using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<CEntity, CContext> : IEntityRepository<CEntity>
        where CEntity:class, IEntity ,new()
        where CContext:DbContext, new()
    {
        public void Add(CEntity entity)
        {
            using (CContext context = new CContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CEntity entity)
        {
            using (CContext context = new CContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CEntity Get(Expression<Func<CEntity, bool>> filter)
        {
            using (CContext context = new CContext())
            {
                return context.Set<CEntity>().SingleOrDefault(filter);
            }
        }

        public List<CEntity> GetAll(Expression<Func<CEntity, bool>> filter = null)
        {
            using (CContext context = new CContext())
            {
                return filter == null ? context.Set<CEntity>().ToList() : context.Set<CEntity>().Where(filter).ToList();
            }
        }

        public void Update(CEntity entity)
        {
            using (CContext context = new CContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
