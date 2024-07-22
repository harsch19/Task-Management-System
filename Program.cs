using TaskManager;

public class Program
{
    public static void Main(string[] args)
    {
        var dsaSelector = new DsaSelector();
        var taskActionHandler = new TaskActionHandler();

        while (true)
        {
            ITaskManager taskManager = dsaSelector.SelectDataStructure();
            if (taskManager == null) continue;

            taskActionHandler.HandleActions(taskManager);
            break;
        }
    }
}
