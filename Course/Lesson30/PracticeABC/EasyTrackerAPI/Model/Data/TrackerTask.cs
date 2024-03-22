public class TrackerTask
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletionDate { get; set; }
    public User AssignedUser { get; set; }
}
