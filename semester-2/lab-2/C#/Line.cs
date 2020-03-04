namespace lab_2
{
    public class Line
    {

        private char[] _str;
        public char[] Str => _str;

        public Line(string istr)
        {
            _str = istr.ToCharArray();
        }
        
        
    }
}