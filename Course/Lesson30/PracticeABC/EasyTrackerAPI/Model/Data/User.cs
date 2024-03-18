public class User
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public List<TrackerTask>? Tasks { get; set; }
}