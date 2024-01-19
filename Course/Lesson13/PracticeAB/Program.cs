using System;
using System.Collections.Generic; 
using System.Text.Json;
namespace PracticeAB;

[System.Serializable] public class Person_1 {

    public int id {get; set;}
    public string name {get; set;}
    public string email {get; set;}
    public bool isVerified {get; set;}

    public Person_1(){}

    public Person_1(int id, string name, string email, bool isVerified) {
        this.id = id;
        this.name = name;
        this.email = email;
        this.isVerified = isVerified;
    }
}

public class Person_2 {
    public string orderId {get; set;}
    public string customerName {get; set;}
    public double totalPrice {get; set;}
    public string[] items {get; set;}

    public Person_2() {}

    public Person_2(string orderId, string customerName, double totalPrice, string[] items) {
        this.orderId = orderId;
        this.customerName = customerName;
        this.totalPrice = totalPrice;
        this.items = items;
    }
}


public class Book {
    public string title {get; set;}
    public string author {get; set;}
    public int year {get; set;}
    public Book() {}

    public Book(string title, string author, int year) {
        this.title = title;
        this.author = author;
        this.year = year;
    }
}


class Program
{
    static void Main(string[] args)
    {

        const string path = "1.json";

        string jsonFromFile = File.ReadAllText(path);
        Person_1 Ivan = JsonSerializer.Deserialize<Person_1>(jsonFromFile);
        Console.WriteLine(Ivan.email);
        const string path2 = "2.json";

        jsonFromFile = File.ReadAllText(path2);
        Person_2 Anna = JsonSerializer.Deserialize<Person_2>(jsonFromFile);
        Console.WriteLine(Anna.totalPrice*0.9);
        string[] c = Anna.items;
        Anna.items = new string[3];
        Anna.items[0] = c[0];
        Anna.items[1] = c[1];
        Anna.items[2] = "Салфетки";
        Anna.totalPrice += 1550;
        Anna.totalPrice*=0.98;
        Console.WriteLine(Anna.totalPrice);

        Book book = new Book("Евгений Онегин", "Александр Пушкин", 1831);
        string json = JsonSerializer.Serialize(book);
        Console.WriteLine(json); 

        const string path3 = "5.json";
        File.WriteAllText(path3, json);
    }
}