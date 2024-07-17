using List;
using Dictionary;
using LinkedList;
using BST;
using TaskManager;

public class Program
{
    public static void Main(string[] args)
    {
        ITaskManager taskManager = null;
        
        while (true)
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
                    taskManager = new ListManager();
                    break;
                case 2:
                    taskManager = new DictionaryManager();
                    break;
                case 3:
                    taskManager = new LinkedListManager(new LinkedListDB());
                    break;
                case 4:
                    taskManager = new TreeManager(new TreeDB());
                    break;
                default:
                    Console.WriteLine("Invalid data structure choice. Please try again.");
                    continue;
            }

            while (true)
            {
                Console.WriteLine("\n\n1. Add task");
                Console.WriteLine("2. View all tasks");
                Console.WriteLine("3. Find task by ID");
                Console.WriteLine("4. Update task");
                Console.WriteLine("5. Delete task");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        TaskManagerActions.AddTask(taskManager);
                        break;
                    case 2:
                        TaskManagerActions.ViewTasks(taskManager);
                        break;
                    case 3:
                        TaskManagerActions.SearchTaskByID(taskManager);
                        break;
                    case 4:
                        TaskManagerActions.UpdateTask(taskManager);
                        break;
                    case 5:
                        TaskManagerActions.DeleteTask(taskManager);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
