using System;
using System.IO;
using System.Linq;

namespace lab_4
{
    public class CString
    {
        private char[] Value { get; private set; }

        public CString(int length)
        {
            Value = new char[length];
        }
        
        public CString(CString cString)
        {
            Value = cString.Value;
        }
        
        public CString(params char[] value)
        {
            Value = value;
        }

        public int GetLength() => Value.Length;

        public char[] GetValue() => Value;

        public char this[int index]
        {
            get => Value[index];
            set => Value[index] = value;
        }

        public static CString operator +(CString one, CString two)
        {
            int newLength = one.GetLength() + two.GetLength();
            CString newString = new CString(newLength);
            for (int i = 0; i < newLength; i++)
            {
                if (i < one.GetLength())
                {
                    newString[i] = one[i];
                }
                else
                {
                    newString[i] = two[i - one.GetLength()];
                }
            }

            return newString;
        }
        
        public static CString operator -(CString one, char c)
        {
            CString newString = new CString(one.GetLength() - one.GetValue().Count(q => q == c));
            int step = 0;
            if (one.GetValue().Contains(c))
            {
                for (int i = 0; i < one.GetLength(); i++)
                {
                    if (c == one[i]) {continue;}
                    newString[step] = one[i];
                    step++;
                }
                return newString;
            }
            throw new InvalidDataException("Char " + c + " does not exist in MyString object.");
        }
    }
}
