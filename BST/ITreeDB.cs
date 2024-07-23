namespace BST
{
    public interface ITreeDB
    {
        public TreeNode GetTreeObj();
        public TreeNode GetTreeObj(Task task);
        public void SetRoot(TreeNode root);
    }
}