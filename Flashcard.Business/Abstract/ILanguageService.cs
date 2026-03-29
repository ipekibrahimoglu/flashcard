using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Flashcard.Entities.Concrete;

namespace Flashcard.Business.Abstract
{
    public interface ILanguageService
    {
        List<Language> GetAll();

        IResult Add(Language language);





    }
}
