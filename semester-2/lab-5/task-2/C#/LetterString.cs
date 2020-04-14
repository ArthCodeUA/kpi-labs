using System;
using System.Linq;

namespace lab_5_2
{
    public class LetterString : BaseString
    {
        public LetterString(params char[] str) : base(str)
        {
            if (!str.All(Char.IsLetter))
            {
                throw new Exception("String should only contain letters!");
            }
        }
        
        public override void RemoveCharacter(char c = 'a')
        {
            base.RemoveCharacter(c);
        }
    }
}