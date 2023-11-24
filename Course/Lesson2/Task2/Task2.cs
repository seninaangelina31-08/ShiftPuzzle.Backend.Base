//Попросите пользователя ввести свой год рождения, а затем используйте переменную для вычисления и вывода его возраста.
Console.Write("Введите год рождения: ");
int age = Convert.ToInt32(Console.ReadLine());
age = 2023 - age;
Console.WriteLine("Вам  " + age + " лет");