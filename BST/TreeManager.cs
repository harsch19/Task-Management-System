using System;
using TaskManager;

namespace BST
{
    public class TreeManager : ITaskManager
    {
        private readonly ITreeDB db;

        public TreeManager(ITreeDB db)
        {
            this.db = db;
        }

        public bool AddTask(Task task)
        {
            TreeNode Root = db.GetTreeObj();
            InsertItem(Root, task.ID, task);
            return true;
        }

        private TreeNode InsertItem(TreeNode node, int key, Task value)
        {
            if (node == null)
            {
                return db.GetTreeObj(value);
            }
            if (key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else if (key > node.Key)
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }
            return node;
        }

        public void DisplayTasks()
        {
            if (db.GetTreeObj() == null){
                Console.WriteLine("No tasks found");
                return;
            }
            TreeNode Root = db.GetTreeObj();
            InOrderTraversal(Root);
        }

        private void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine(node.Value);
                InOrderTraversal(node.RightChild);
            }
        }

        public Task SearchTask(int id)
        {
            TreeNode Root = db.GetTreeObj();
            var node = Find(Root, id);
            Task task = node.Value;
            return task;
        }

        private TreeNode Find(TreeNode node, int key)
        {
            if (node == null || node.Key == key)
            {
                return node;
            }
            else if (key < node.Key)
            {
                return Find(node.LeftChild, key);
            }
            else
            {
                return Find(node.RightChild, key);
            }
        }

        public Task UpdateTask(int id, string title, string desc, string status)
        {
            TreeNode Root = db.GetTreeObj();
            var node = Find(Root, id);
            if (node != null)
            {
                node.Value.Title = title;
                node.Value.Desc = desc;
                node.Value.Status = status;
                return node.Value;
            }
            return null;
        }

        public bool DeleteTask(int id)
        {
            TreeNode root = db.GetTreeObj();
            var success = false;
            root = DeleteNode(root, id, ref success);
            db.SetRoot(root);
            return success;
        }

        private TreeNode DeleteNode(TreeNode root, int key, ref bool success)
        {
            if (root == null) return root;

            if (key < root.Key)
            {
                root.LeftChild = DeleteNode(root.LeftChild, key, ref success);
            }
            else if (key > root.Key)
            {
                root.RightChild = DeleteNode(root.RightChild, key, ref success);
            }
            else
            {
                success = true;

                if (root.LeftChild == null)
                {
                    return root.RightChild;
                }
                else if (root.RightChild == null)
                {
                    return root.LeftChild;
                }

                if (root == db.GetTreeObj())
                {
                    TreeNode tempRoot = new TreeNode(MinValue(root.RightChild), Find(root.RightChild, MinValue(root.RightChild)).Value);
                    tempRoot.LeftChild = root.LeftChild;
                    tempRoot.RightChild = DeleteNode(root.RightChild, tempRoot.Key, ref success);
                    return tempRoot;
                }

                root.Key = MinValue(root.RightChild);
                root.Value = Find(root.RightChild, root.Key).Value;
                root.RightChild = DeleteNode(root.RightChild, root.Key, ref success);
            }

            return root;
        }

        private int MinValue(TreeNode node)
        {
            int minValue = node.Key;
            while (node.LeftChild != null)
            {
                node = node.LeftChild;
                minValue = node.Key;
            }
            return minValue;
        }
    }
}
