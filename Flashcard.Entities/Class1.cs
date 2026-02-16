using Flashcard.Entities.Abstract;

namespace Flashcard.Entities
{
    public class Word:IEntity
    {
        public int Id { get; set; } // Birincil anahtar
        public string OriginalText { get; set; } // İtalyanca kelime
        public string Translation { get; set; } // Türkçe anlamı
        public string Language { get; set; }
                                            

    }
}
