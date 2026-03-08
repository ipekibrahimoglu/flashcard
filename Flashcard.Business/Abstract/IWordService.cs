using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Flashcard.Entities.Concrete;

namespace Flashcard.Business.Abstract
{
    public interface IWordService
    {
        List<Word> GetAll();
        Word GetById(int id);
        IResult Add(Word word);
        IResult Delete(int id);
        IResult Update(Word word);

           
    }
}
