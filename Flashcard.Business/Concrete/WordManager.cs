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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

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

        public object Delete(Word word)

        {
            var wordToDelete = _wordDal.Get(w => w.Id == word.Id);

            if (wordToDelete != null)
            {

                _wordDal.Delete(wordToDelete);

                return new { Success = true, message = "başarılı" };

            }

            return new { Success = false, message = "başarısız, silinmedi" };
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

        void IWordService.Delete(Word word)
        {
            throw new NotImplementedException();
        }
    }
}