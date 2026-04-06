using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcard.Entities.Concrete;

namespace Flashcard.DataAccess.Abstract
{
    public interface ILanguageDal:IEntityRepository<Language>
    {
    }
}
