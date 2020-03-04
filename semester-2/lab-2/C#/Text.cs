using System;
using System.Linq;

namespace lab_2
{
    public class Text
    {
        private Line[] _content;

        public Line[] Content => _content;

        public Text()
        {
            _content = new Line[]{};
        }

        public void AddLine(Line newLine)
        {
            Array.Resize(ref _content, _content.Length+1);
            _content[^1] = newLine;
        }
        
        public void RemoveLine(int lineNumber)
        {
            Line[] newText = new Line[_content.Length-1];
            for (var i = 0; i < _content.Length; i++)
            {
                if (i == lineNumber) continue;
                if (i < lineNumber)
                {
                    newText[i] = _content[i];
                }
                if(i > lineNumber)
                {
                    newText[i - 1] = _content[i];
                }
            }

            _content = newText;
        }

        public void ClearText()
        {
            _content = new Line[]{};
        }

        public double AvgLength()
        {
            return _content.Average(x => x.Str.Length);
        }

        public double VowelsPercentage()
        {
            double letters = 0;
            double vowels = 0;
            foreach (Line line in _content)
            {
                foreach (char c in line.Str)
                {
                    letters++;
                    if (!char.IsLetter(c)) continue;
                    if ("aeiouAEIOU".IndexOf(c) >= 0)
                    {
                        vowels++;
                    }
                }
            }
            return Math.Round((vowels / letters) * 100, 2);
        }

        public void RemoveRegexp(string regexp)
        {
            if (regexp.Length > 0)
            {
                char[] search = regexp.ToCharArray();
                char key = search[0];
                for (int i = _content.Length-1; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    char[] currentLine = _content[i].Str;
                    for (int j = 0; j < currentLine.Length; j++)
                    {
                        char currentChar = currentLine[j];
                        if (currentChar == key && j + search.Length <= currentLine.Length)
                        {
                            bool found = true;
                            for (int k = j; k < j+search.Length; k++)
                            {
                                if (currentLine[k] != search[k - j])
                                {
                                    found = false;
                                    break;
                                }
                            }
                            if (found)
                            {
                                RemoveLine(i);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}