using TaskManager;

namespace List
{
    public class ListManager : ITaskManager
    {
        private ListDB tasks;

        public ListManager()
        {
            tasks = new ListDB();
        }

        public bool AddTask(Task task)
        {
            tasks.Tasks.Add(task);
            return true;
        }
        public void DisplayTasks()
        {
            foreach (var task in tasks.Tasks)
            {
                Console.WriteLine(task);
            }
        }

        public Task SearchTask(int id)
        {
            return tasks.Tasks.FirstOrDefault(t => t.ID == id);
        }

        public Task UpdateTask(int id, string title, string desc, string status)
        {
            var task = SearchTask(id);
            if (task != null)
            {
                task.Title = title;
                task.Desc = desc;
                task.Status = status;
                return task;
            }
            return null;
        }

        public bool DeleteTask(int id)
        {
            var task = SearchTask(id);
            if (task != null)
            {
                tasks.Tasks.Remove(task);    
                return true;
            }
            return false;
        }
    }
}