using TaskManager;

namespace Dictionary
{
    public class DictionaryManager : ITaskManager
    {
        private readonly DictionaryDB db;

        public DictionaryManager()
        {
            db = new DictionaryDB();
        }

        public bool AddTask(Task task)
        {
            return db.AddTask(task);
        }

        public void DisplayTasks()
        {
            db.DisplayTasks();
        }

        public Task SearchTask(int id)
        {
            return db.SearchTask(id);
        }

        public Task UpdateTask(int id, string title, string desc, string status)
        {
            return db.UpdateTask(id, title, desc, status);
        }

        public bool DeleteTask(int id)
        {
            return db.DeleteTask(id);
        }
    }
}
