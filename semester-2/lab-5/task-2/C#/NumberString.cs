using System;
using System.Linq;

namespace lab_5_2
{
    public class NumberString : BaseString
    {
        public NumberString(params char[] str) : base(str)
        {
            if (!str.All(Char.IsDigit))
            {
                throw new Exception("String should only contain digits!");
            }
        }

        public override void RemoveCharacter(char c = '5')
        {
            base.RemoveCharacter(c);
        }
    }
}