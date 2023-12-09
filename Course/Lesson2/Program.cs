Console.WriteLine("ваше имя");
string imia = Console.ReadLine();
Console.WriteLine("привет," + imia +".");





Console.WriteLine("Введите год своего рождения:");
int yearOfBirth = Convert.ToInt32(Console.ReadLine());
int age = DateTime.Now.Year - yearOfBirth;
Console.WriteLine("Ваш возраст:" + age + "лет");






Console.WriteLine("Введите имя:");
string name1 = Console.ReadLine();
Console.WriteLine("Введите телефонный номер:");
string phoneNumber1 = Console.ReadLine();

Console.WriteLine("Введите имя:");
string name2 = Console.ReadLine();
Console.WriteLine("Введите телефонный номер:");
string phoneNumber2 = Console.ReadLine();

Console.WriteLine("Имя:" + name1 + "телефонный номер:" + phoneNumber1);
Console.WriteLine("Имя:" + name2 + "телефонный номер:" + phoneNumber2);






Console.WriteLine("введи текст");
string tekst = Console.ReadLine();
Console.WriteLine(tekst);