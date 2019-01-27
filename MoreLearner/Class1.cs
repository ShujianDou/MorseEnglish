using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearner
{



    public class CMain
    {
        #region Init
        
        IReadOnlyDictionary<Char, String> CharMorseDictionary = new Dictionary<Char, String>();

        public CMain(Dictionary<char, string> charMorseDictionary)
        {
            CharMorseDictionary = charMorseDictionary ?? throw new ArgumentNullException(nameof(charMorseDictionary));
            charMorseDictionary.Add('a', ".-");
            charMorseDictionary.Add('b', "-...");
            charMorseDictionary.Add('c', "-.-.");
            charMorseDictionary.Add('d', "-..");
            charMorseDictionary.Add('e', ".");
            charMorseDictionary.Add('f', "..-.");
            charMorseDictionary.Add('g', "--.");
            charMorseDictionary.Add('h', "....");
            charMorseDictionary.Add('i', "..");
            charMorseDictionary.Add('j', ".---");
            charMorseDictionary.Add('k', "-.-");
            charMorseDictionary.Add('l', ".-..");
            charMorseDictionary.Add('m', "--");
            charMorseDictionary.Add('n', "-.");
            charMorseDictionary.Add('o', "---");
            charMorseDictionary.Add('p', ".--.");
            charMorseDictionary.Add('q', "--.-");
            charMorseDictionary.Add('r', ".-.");
            charMorseDictionary.Add('s', "...");
            charMorseDictionary.Add('t', "-");
            charMorseDictionary.Add('u', "..-");
            charMorseDictionary.Add('v', "...-");
            charMorseDictionary.Add('w', ".--");
            charMorseDictionary.Add('x', "-..-");
            charMorseDictionary.Add('y', "-.--");
            charMorseDictionary.Add('z', "--..");

            // Numbers
            charMorseDictionary.Add('0', "-----");
            charMorseDictionary.Add('1', ".----");
            charMorseDictionary.Add('2', "..---");
            charMorseDictionary.Add('3', "...--");
            charMorseDictionary.Add('4', "....-");
            charMorseDictionary.Add('5', ".....");
            charMorseDictionary.Add('6', "-....");
            charMorseDictionary.Add('7', "--...");
            charMorseDictionary.Add('8', "---..");
            charMorseDictionary.Add('9', "----.");

            //Special
            charMorseDictionary.Add(' ', "/");

            
        }

        public CMain()
        {

        }
        #endregion

        public void RunNorm()
        {
            Forms.norm form = new Forms.norm();
            form.ShowDialog();
        }

        public String MorseToChar(String MorseString) {
            try
            {
                List<Char> Tlist = new List<Char>();
                String[] MorseStringSplit = MorseString.Split(' ');
                foreach (String MorseChar in MorseStringSplit)
                {
                    int IndexofValue = Array.IndexOf(CharMorseDictionary.Values.ToArray(), MorseChar);
                    Tlist.Add(CharMorseDictionary.Keys.ElementAt(IndexofValue));
                }

                return String.Join("", Tlist.ToArray());
            }
            catch(InvalidCharacterDetected x)
            {
                return x.Message;
            }
        }
        public String CharToMorse(String Character) {
            try
            {
                List<String> Tlist = new List<String>();

                foreach (Char c in Character.ToLower())
                {
                    int IndexofKey = Array.IndexOf(CharMorseDictionary.Keys.ToArray(), c);
                    Tlist.Add(CharMorseDictionary.Values.ElementAt(IndexofKey));
                }
                return String.Join("", Tlist.ToArray());
            }
            catch(InvalidCharacterDetected x)
            {
                return x.Message;
            }
        }
    }

    [Serializable]
    public class InvalidCharacterDetected : Exception {
        public InvalidCharacterDetected()
        {

        }
        public InvalidCharacterDetected(string x)
        : base(message: String.Format("Failed to convert from an invalid character. Please remember to not use symbols.", x))
        {

        }
    }
}
