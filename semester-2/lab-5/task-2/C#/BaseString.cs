using System.IO;
using System.Linq;

namespace lab_5_2
{
    public class BaseString
    {
        protected char[] StrValue { get; set; }

        public BaseString(params char[] str)
        {
            StrValue = str;
        }

        public int GetLength() => StrValue.Length;

        public char[] GetValue() => StrValue;

        public virtual void RemoveCharacter(char l)
        {
            char[] newValue = new char[GetLength() - StrValue.Count(c => c == l)];
            int step = 0;
            if (StrValue.Contains(l))
            {
                for (int i = 0; i < GetLength(); i++)
                {
                    if (l == StrValue[i]) {continue;}
                    newValue[step] = StrValue[i];
                    step++;
                }

                StrValue = newValue;
            }
            else
            {
                throw new InvalidDataException("Char " + l + " does not exist in MyString object.");
            }
        }
    }
}