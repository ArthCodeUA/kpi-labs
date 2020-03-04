using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Text arthcode = new Text();
            arthcode.AddLine(new Line("Lorem ipsum dolor sit amet"));
            arthcode.AddLine(new Line("consectetur adipiscing elit"));
            arthcode.AddLine(new Line("Maecenas odio tellus, dictum"));
            arthcode.AddLine(new Line("in mattis sed, vehicula ut ex"));
            Console.WriteLine(arthcode.AvgLength());
            Console.WriteLine(arthcode.VowelsPercentage());
            Console.WriteLine(arthcode.AvgLength());
            Console.WriteLine(arthcode.VowelsPercentage());
            arthcode.RemoveRegexp("mat");
            PrintText(arthcode);
            Console.WriteLine();
            arthcode.ClearText();
            arthcode.AddLine(new Line("Lorem ipsum dolor sit amet"));
            arthcode.AddLine(new Line("consectetur adipiscing elit"));
            arthcode.AddLine(new Line("Maecenas odio tellus, dictum"));
            arthcode.AddLine(new Line("in mattis sed, vehicula ut ex"));
            arthcode.RemoveLine(2);
            PrintText(arthcode);
        }

        static void PrintText(Text text)
        {
            foreach (Line line in text.Content)
            {
                Console.WriteLine(line.Str);
            }
        }
    }
}