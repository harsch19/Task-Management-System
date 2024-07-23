using TaskManager;

namespace List
{
    public class ListManager : ITaskManager
    {
        private readonly List<Task> tasks;
        private readonly IListDB db;

        public ListManager(IListDB db)
        {
            this.db = db;
            tasks = db.GetListDBObj();
        }

        public bool AddTask(Task task)
        {
            if (tasks.All(t => t.ID != task.ID))
            {
                tasks.Add(task);
                return true;
            }
            return false;
        }

        public void DisplayTasks()
        {
            if (tasks.Count == 0){
                Console.WriteLine("No tasks found");
                return;
            }
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public Task SearchTask(int id)
        {
            return tasks.FirstOrDefault(t => t.ID == id);
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
                tasks.Remove(task);
                return true;
            }
            return false;
        }
    }
}
