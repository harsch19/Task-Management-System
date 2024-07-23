using TaskManager;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            ITaskManager taskManager = DsaSelector.SelectDataStructure();
            if (taskManager == null) continue;

            TaskActionHandler.HandleActions(taskManager);
            break;
        }
    }
}
