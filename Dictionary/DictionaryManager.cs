using TaskManager;
namespace Dictionary
{
    public class DictionaryManager : ITaskManager
    {
        private readonly Dictionary<int, Task> tasks;

        public DictionaryManager()
        {
            var db = new DictionaryDB();
            tasks = db.GetDictionaryDBObj();
        }

        public bool AddTask(Task task)
        {
            if (!tasks.ContainsKey(task.ID))
            {
                tasks.Add(task.ID, task);
                return true;
            }
            return false;
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found");
                return;
            }
            foreach (var task in tasks.Values)
            {
                Console.WriteLine(task);
            }
        }

        public Task SearchTask(int id)
        {
            tasks.TryGetValue(id, out var task);
            return task;
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
            return tasks.Remove(id);
        }
    }
}
