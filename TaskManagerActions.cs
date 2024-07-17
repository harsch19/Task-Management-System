using System.Reflection.Metadata;

namespace TaskManager
{
    public static class TaskManagerActions
    {
        public static void AddTask(ITaskManager taskManager)
        {
            Console.Write("Enter task ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();
            Console.Write("Enter task description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter task status: ");
            string status = Console.ReadLine();

            Task task = new Task(id, title, desc, status);
            
            if (taskManager.AddTask(task)) {
                Console.WriteLine("\n\tTask added successfully.");
            } else {
                Console.WriteLine("\n\tFailed to add task.");
            }
        }

        public static void ViewTasks(ITaskManager taskManager)
        {
            Console.WriteLine("All Tasks:");
            taskManager.DisplayTasks();
        }

        public static void UpdateTask(ITaskManager taskManager)
        {
            Console.Write("Enter task ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new task title: ");
            string title = Console.ReadLine();
            Console.Write("Enter new task description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter new task status: ");
            string status = Console.ReadLine();

            Task task = taskManager.UpdateTask(id, title, desc, status);
            Console.WriteLine("\n\tTask updated successfully.");
            Console.WriteLine(task);
        }

        public static Task SearchTaskByID(ITaskManager taskManager)
        {
            Console.Write("Enter task ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var task = taskManager.SearchTask(id);
            if (task != null)
            {
                Console.WriteLine(task);
            }
            else
            {
                Console.WriteLine("\n\tTask not found.");
            }
            return task;
        }
        
        public static void DeleteTask(ITaskManager taskManager)
        {
            Console.Write("Enter task ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (taskManager.DeleteTask(id)){
                Console.WriteLine("\n\tTask deleted successfully.");
            } else {
                Console.WriteLine("\n\tTask deletion failed");
            }
        }
    }
}
