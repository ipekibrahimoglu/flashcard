using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Flashcard.Entities.Abstract;


namespace Flashcard.Entities.Concrete
{
    public class Language:IEntity
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}