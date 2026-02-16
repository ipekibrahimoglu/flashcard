using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcard.DataAccess.Abstract;
using Flashcard.Entities;

namespace Flashcard.DataAccess.Concrete
{
    public class EfWordDal: EFEntityRepositoryBase<Word, FlashCardDbContext>, IWordDal   

    {


    }
}
