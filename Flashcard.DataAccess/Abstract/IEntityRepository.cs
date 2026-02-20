using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Flashcard.Entities.Abstract;
using Flashcard.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Flashcard.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T Entity);
        void Update(T Entity);  

        void Delete(T Entity);

        List<T>GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

    }
}
