using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary
{
    public class DictionaryDB
    {
        private  Dictionary<int, Task> tasks;

        public DictionaryDB()
        {
            tasks = new Dictionary<int, Task>();
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
