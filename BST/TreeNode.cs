namespace BST
{
    public class TreeNode
    {
        public int Key { get; set; }
        public Task Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int key, Task value)
        {
            Key = key;
            Value = value;
        }
    }
}