public class Task
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public string Status { get; set; }

    public Task(int id, string title, string desc, string status) {
        ID = id;
        Title = title;
        Desc = desc;
        Status = status;
    }

    public override string ToString() {
        return $"ID: {ID}, Title: {Title}, Description: {Desc}, Status: {Status}";
    }
}
