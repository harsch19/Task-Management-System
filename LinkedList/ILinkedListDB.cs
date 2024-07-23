namespace LinkedList
{
    public interface ILinkedListDB
    {
        Node GetLinkedListDBObj();
        Node GetLinkedListDBObj(Task task);
        void SetFirstNode(Node node);
    }
}