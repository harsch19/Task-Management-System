namespace LinkedList
{
    public class LinkedListDB : ILinkedListDB
    {
        private Node First { get; set; }

        public Node GetLinkedListDBObj() {
            return First;
        }
        public Node GetLinkedListDBObj(Task task) {
            if (First == null) {
                First = new Node(task);
                return null;
            }
            return new Node(task);
        }

        public void SetFirstNode(Node node) {
            First = node;
        }
    }
}
