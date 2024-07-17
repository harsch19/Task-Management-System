using System.Collections.Generic;

namespace List
{
    public class ListDB
    {
        public List<Task> Tasks { get; set; }

        public ListDB()
        {
            Tasks = new List<Task>();
        }
    }
}
