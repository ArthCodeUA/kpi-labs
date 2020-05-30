namespace lab_7
{
    public class Node
    {
        public short Data { get; }
        public Node Next { get; set; }

        public Node(short data)
        {
            Data = data;
            Next = null;
        }
    }
}