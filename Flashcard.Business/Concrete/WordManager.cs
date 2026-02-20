using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using Flashcard.Business.Abstract;
using Flashcard.DataAccess.Abstract;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using Flashcard.Entities.Concrete;

namespace Flashcard.Business.Concrete
{
    public class WordManager : IWordService

    {
        private readonly IWordDal _wordDal;
        public WordManager(IWordDal wordDal) {

                _wordDal = wordDal;       
        }    
        public void Add(Word word)
        {
            _wordDal.Add(word);
        }

        public void Delete(Word word)
        {
            _wordDal.Delete(word);
        }

        public List<Word> GetAll()
        {
          return _wordDal.GetAll();
        }

        public Word GetById(int id)
        {
           return _wordDal.Get(w => w.Id == id);
        }

        public void Update(Word word)
        {
            _wordDal.Update(word);
        }
    }
}