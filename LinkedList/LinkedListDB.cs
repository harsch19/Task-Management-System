namespace LinkedList
{
    public class LinkedListDB
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

        public void DeleteFirst() {
            First = First.Next;
        }
    }
}