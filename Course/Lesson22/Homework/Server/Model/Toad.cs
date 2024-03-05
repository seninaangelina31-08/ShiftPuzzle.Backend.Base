namespace Homework;
using System;
using System.ComponentModel.DataAnnotations;

public class Toad
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [Range(0, 40)]
    public int Age { get; set; }

    [StringLength(150, MinimumLength = 3)]
    public string Color { get; set; }

    [StringLength(150)]
    public string Specie { get; set; }

    public Toad(string name, int age, string color, string specie)
    {
        Name = name;
        Age = age;
        Color = color;
        Specie = specie;
    }
}
