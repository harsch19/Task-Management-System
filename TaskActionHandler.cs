namespace TaskManager
{
    public class TaskActionHandler
    {
        public static void HandleActions(ITaskManager taskManager)
        {
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