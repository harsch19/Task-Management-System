using System.Collections.Generic;

namespace List
{
    public class ListDB
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
