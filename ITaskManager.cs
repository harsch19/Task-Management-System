namespace TaskManager {
    public interface ITaskManager
    {
        bool AddTask(Task task);
        void DisplayTasks();
        Task SearchTask(int id);
        Task UpdateTask(int id, string title, string description, string status);
        bool DeleteTask(int id);
    }
}
