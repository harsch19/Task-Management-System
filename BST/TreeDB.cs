namespace BST
{
    public class TreeDB
    {
        private TreeNode Root { get; set; } = null;

        public bool AddTask(Task task)
        {
            Root = InsertItem(Root, task.ID, task);
            return true;
        }

        private TreeNode InsertItem(TreeNode node, int key, Task value)
        {
            if (node == null)
            {
                node = new TreeNode(key, value);
                return node;
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
            var node = Find(Root, id);
            return node == null ? null : node.Value;
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
            var success = false;
            Root = DeleteNode(Root, id, ref success);
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