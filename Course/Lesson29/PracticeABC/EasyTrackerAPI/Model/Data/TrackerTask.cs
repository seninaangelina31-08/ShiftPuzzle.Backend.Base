using System.ComponentModel.DataAnnotations;

public class TrackerTask
{  
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public TrackerTask(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

}