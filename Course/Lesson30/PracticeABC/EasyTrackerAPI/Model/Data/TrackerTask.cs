public class TrackerTask
{  
    public int ID { get; set; }
    public string? Name { get; internal set; }
    public string? Description { get; internal set; }
    public bool IsComplete {get; set;}
    public DateTime? DueDate {get; set;}
    public User? AssignedUser {get; set;}
}