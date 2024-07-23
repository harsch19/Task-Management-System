namespace List
{
    public class ListDB : IListDB
    {
        private List<Task> tasks;

        public ListDB()
        {
            tasks = new List<Task>();
        }

        public List<Task> GetListDBObj()
        {
            return tasks;
        }
    }
}
