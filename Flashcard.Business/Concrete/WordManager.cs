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
using Core.Utilities.Results;

namespace Flashcard.Business.Concrete
{
    public class WordManager : IWordService

    {
        private readonly IWordDal _wordDal;


        public WordManager(IWordDal wordDal)
        {

            _wordDal = wordDal;
        }
        public Core.Utilities.Results.IResult Add(Word word)
        {
            var result = _wordDal.Get(w => w.OriginalText.ToLower() == word.OriginalText.ToLower());

            if (result != null)
            {

                return new ErrorResult("kelime zaten var");

            }

            if (string.IsNullOrEmpty(word.OriginalText))
            {

                return new ErrorResult("boş kelime eklenemez");


            }

            _wordDal.Add(word);//nasıl kontrol yapılmalı ?

            return new SuccessResult("eklendi");


        }

        public Core.Utilities.Results.IResult Delete(int id)

        {
            var wordToDelete = _wordDal.Get(w => w.Id == id);

            if (wordToDelete == null)
            {
                return new ErrorResult("kelime bulunamadı");

            }

            _wordDal.Delete(wordToDelete);

            return new SuccessResult("silme başarılı");
        }


        public List<Word> GetAll()
        {
            return _wordDal.GetAll();

        }

        public Word GetById(int id)
        {
            return _wordDal.Get(w => w.Id == id);
        }

        public Core.Utilities.Results.IResult Update(Word word)
        {
            var result = _wordDal.Get(w => w.Id == word.Id);
            if (result == null)
            {

                return new ErrorResult("güncellenecek kelime bulunmadı");

            }

            if (word.OriginalText.Length < 2)
            {

                return new ErrorResult("2 harften uzun bir kelime gerekli");

            }

            _wordDal.Update(word);

            return new SuccessResult("kelime başarıyla güncellendi");


        }
    }
}
    