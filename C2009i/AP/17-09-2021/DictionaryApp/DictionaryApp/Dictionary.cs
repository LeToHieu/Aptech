using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    public class Dictionary : IDictionary
    {
        public List<Word> Words { get; set; }
        public void AddWord(string word, string meaning)
        {
            if(Words.Where(item => item._Word.Equals(word)).ToList().Count == 0)
            {
                Word newWordObject = new Word() { 
                    _Word = word,
                    Meaning = meaning
                };
                Words.Add(newWordObject);
            }
        }

        public void EditWord(string word, string meaning)
        {
            //giong nhu Stream trong Java
            Word foundWord = this.Words.Where(item => item._Word.Equals(word)).FirstOrDefault();
            if (foundWord != null) {
                foundWord._Word = word;
                foundWord.Meaning = meaning;
            }

        }

        public void List()
        {
           foreach(Word word in this.Words) {
                word.Display();
           }
        }

        public bool Remove(string word)
        {
            Word foundWord = this.Words.Where(item => item._Word.Equals(word)).FirstOrDefault();
            return this.Words.Remove(foundWord);
            /*
            if (foundWord != null) {
                this.Words.Remove(foundWord);
                return true;
            }
            return false;            
            */
        }

        public void Search(string word)
        {
            Word foundWord = this.Words.Where(item => item._Word.Equals(word)).FirstOrDefault();
            if (foundWord != null) {
                foundWord.Display();
            }
        }
    }
}
