using System;
using TaskManager;

namespace LinkedList
{
    public class LinkedListManager : ITaskManager
    {
        private LinkedListDB db;

        public LinkedListManager(LinkedListDB db)
        {
            this.db = db;
        }

        public bool AddTask(Task task)
        {
            return db.AddNode(task);
        }

        public void DisplayTasks()
        {
            db.DisplayNodes();
        }

        public Task SearchTask(int id)
        {
            return db.SearchNode(id);
        }

        public Task UpdateTask(int id, string title, string desc, string status)
        {
            return db.UpdateNode(id, title, desc, status);
        }

        public bool DeleteTask(int id)
        {
            return db.RemoveNode(id);
        }
    }
}
