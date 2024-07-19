using System;
using TaskManager;

namespace LinkedList
{
    public class LinkedListManager : ITaskManager
    {
        private LinkedListDB db = new LinkedListDB();

        public bool AddTask(Task task)
        {
            Node newNode = db.GetLinkedListDBObj(task);
            Node current = db.GetLinkedListDBObj();
            if (current == null) {
                return true;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;

            return true;
        }

        public void DisplayTasks()
        {
            Node current = db.GetLinkedListDBObj();
            if (current == null) {
                Console.WriteLine("No tasks found");
                return;
            }
            Console.WriteLine("All Tasks:");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public Task SearchTask(int id)
        {
            Node current = db.GetLinkedListDBObj();
            while (current != null)
            {
                if (current.Data.ID == id)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }

        public Task UpdateTask(int id, string title, string desc, string status)
        {
            Node current = db.GetLinkedListDBObj();
            if (current == null) {
                return null;
            }
            while (current != null)
            {
                if (current.Data.ID == id)
                {
                    current.Data.Title = title;
                    current.Data.Desc = desc;
                    current.Data.Status = status;
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }

        public bool DeleteTask(int id)
        {
            Node first = db.GetLinkedListDBObj();

            if (first.Next == null || first.Data.ID == id) {
                db.DeleteFirst();
                return true;
            }

            Node current = first;
            while (current.Next != null)
            {
                if (current.Next.Data.ID == id)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
    }
}
