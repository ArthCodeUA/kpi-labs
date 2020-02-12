namespace lab_1
{
    public static class Functions
    {
        public static void Increment(int a, out int r)
        {
            r = -~a;
        }

        public static bool Equality(int a, int b)
        {
            return !((a ^ b) != 0);
        }
    }
}