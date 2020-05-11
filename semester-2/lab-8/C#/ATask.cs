namespace lab_8
{
    public static class ATask
    {
        public delegate int LineOperation(char symbol, string str);

        public static int GetFirstCharIndex(char symbol, string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}