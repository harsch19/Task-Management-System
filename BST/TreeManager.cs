using TaskManager;

namespace BST
{
    public class TreeManager : ITaskManager
    {
        
        private TreeDB db { get; set; }
        public TreeManager(TreeDB db)
        {
            this.db = db;
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
