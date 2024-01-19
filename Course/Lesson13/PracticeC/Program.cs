namespace PracticeC;
using System;
using System.Text.Json;


[System.Serializable] public class Film
{
    public string title { get; set; }
    public int year { get; set; }
    public Dictionary<string, string> director { get; set; }
    public List<Actor> cast { get; set; }
    public List<string> genres { get; set; }
    public Rating ratings { get; set; }

}

[System.Serializable] public class Actor
{
    public string name { get; set; }
    public string role { get; set }
}
class Program
{
    static void Main(string[] args)
    {

    }
}
