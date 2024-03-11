namespace PracticeA;

public class UserCredentials
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string User { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Pass { get; set; }
}