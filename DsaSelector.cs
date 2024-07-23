using LinkedList;
using List;
using Dictionary;
using BST;
using TaskManager;

public class DsaSelector
{   
    public static ITaskManager SelectDataStructure()
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
                IListDB listdb = new ListDB();
                ITaskManager listManager = new ListManager(listdb);
                return listManager;
            case 2:
                IDictionaryDB dictionaryDB = new DictionaryDB();
                ITaskManager dictionaryManager = new DictionaryManager(dictionaryDB);
                return dictionaryManager;
            case 3:
                ILinkedListDB linkedListDB = new LinkedListDB();
                ITaskManager linkedListManager = new LinkedListManager(linkedListDB);
                return linkedListManager;
            case 4:
                ITreeDB treeDB = new TreeDB();
                ITaskManager treeManager = new TreeManager(treeDB);
                return treeManager;
            default:
                Console.WriteLine("Invalid data structure choice. Please try again.");
                return null;
        }
    }
}
