using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CString s1 = new CString();
            CString s2 = new CString('c', 'd', '#');
            CString s3 = new CString(s2);
            Console.WriteLine(s1.GetValue());
            Console.WriteLine(s2.GetValue());
            Console.WriteLine(s3.GetValue());
            s2 -= '#';
            Console.WriteLine(s2.GetValue());
            s1 = s2 + s3;
            Console.WriteLine(s1.GetValue());
        }
    }
}