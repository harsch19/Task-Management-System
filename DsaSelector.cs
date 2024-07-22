using List;
using Dictionary;
using LinkedList;
using BST;
using TaskManager;

public class DsaSelector
{
    public ITaskManager SelectDataStructure()
    {
        Console.WriteLine("Select Data Structure:");
        Console.WriteLine("1. List");
        Console.WriteLine("2. Dictionary");
        Console.WriteLine("3. Linked List");
        Console.WriteLine("4. Tree");

        int dataStructureChoice = Convert.ToInt32(Console.ReadLine());

        switch (dataStructureChoice)
        {
            case 1:
                return new ListManager();
            case 2:
                return new DictionaryManager();
            case 3:
                return new LinkedListManager();
            case 4:
                return new TreeManager();
            default:
                Console.WriteLine("Invalid data structure choice. Please try again.");
                return null;
        }
    }
}
