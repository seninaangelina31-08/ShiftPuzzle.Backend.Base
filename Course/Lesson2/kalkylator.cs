Console.WriteLine("Введите год своего рождения:");
int yearOfBirth = Convert.ToInt32(Console.ReadLine());
int age = DateTime.Now.Year - yearOfBirth;
Console.WriteLine("Ваш возраст:" age "лет");
