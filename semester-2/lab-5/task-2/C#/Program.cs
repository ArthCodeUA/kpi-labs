using System;

namespace lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseString baseString = new BaseString('a','b','c','1');
            baseString.RemoveCharacter('c');
            Console.WriteLine(baseString.GetValue());
            LetterString letterString = new LetterString('h','e','l','l','o','a');
            letterString.RemoveCharacter();
            Console.WriteLine(letterString.GetValue());
            NumberString numberString = new NumberString('1','3','5','7','5');
            numberString.RemoveCharacter();
            Console.WriteLine(numberString.GetValue());
        }
    }
}