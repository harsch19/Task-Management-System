namespace LinkedList
{
    public class Node
    {
        public Task Data { get; set; }
        public Node Next { get; set; }

        public Node(Task data)
        {
            Data = data;
            Next = null;
        }
    }
}