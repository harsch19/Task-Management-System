namespace BST
{
    public class TreeDB
    {
        private TreeNode Root { get; set; }

        public TreeNode GetTreeObj() {
            return Root;
        }
        public TreeNode GetTreeObj(Task task) {
            if (Root == null) {
                Root = new TreeNode(task.ID, task);
                return null;
            }
            return new TreeNode(task.ID, task);
        }

        public void SetRoot(TreeNode root)
        {
            Root = root;
        }

    }
}