using System;

namespace LinkedList
{
    public class LinkedListDB
    {
        private Node First { get; set; }

        public LinkedListDB ()
        {
            First = null;
        }

        public bool AddNode(Task task)
        {
            Node newNode = new Node (task);
            if (First == null)
            {
                First = newNode;
            }
            else
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            return true;
        }

        public void DisplayNodes()
        {
            Node current = First;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public Task SearchNode(int id)
        {
            Node current = First;
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

        public Task UpdateNode(int id, string title, string desc, string status)
        {
            Node current = First;
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

        public bool RemoveNode(int id)
        {
            if (First == null)
            {
                return false;
            }

            if (First.Data.ID == id)
            {
                First = First.Next;
                return true;
            }

            Node current = First;
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

