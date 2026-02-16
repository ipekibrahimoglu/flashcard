using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Flashcard.DataAccess.Abstract;
using Flashcard.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Flashcard.DataAccess.Concrete
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TContext: DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(Entity);

                addedEntity.State = EntityState.Added;

                context.SaveChanges();
            }              
        }   
        public void Delete(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(Entity);
                   
                deletedEntity.State = EntityState.Deleted;

                context.SaveChanges();

            }
        }

        public void Update(TEntity Entity)
        {
            using (TContext context = new TContext())
            {

                var updatedEntity = context.Entry(Entity);

                updatedEntity.State = EntityState.Modified;
                    
                context.SaveChanges();

            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }


        public List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                 ? context.Set<TEntity>().ToList()
                 : context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
