using System.Collections.Generic;

namespace Dictionary
{
    public class DictionaryDB : IDictionaryDB
    {
        private Dictionary<int, Task> tasks;

        public DictionaryDB()
        {
            tasks = new Dictionary<int, Task>();
        }

        public Dictionary<int, Task> GetDictionaryDBObj()
        {
            return tasks;
        }
    }
}
