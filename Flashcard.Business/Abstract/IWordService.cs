using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcard.Entities.Concrete;

namespace Flashcard.Business.Abstract
{
    public interface IWordService
    {
        List<Word> GetAll();
        Word GetById(int id);
        void Add(Word word);
        object Delete(Word word);
        void Update(Word word);

           
    }
}
