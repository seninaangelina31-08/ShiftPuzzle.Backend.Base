public class User
{  
    public int ID { get; set; }
    public string? Name { get; internal set; }
    public string? Email { get; internal set; }
    public string? Password { get; set; }
    public List<TrackerTask>? Tasks { get; set; }
}