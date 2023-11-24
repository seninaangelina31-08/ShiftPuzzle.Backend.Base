int year_born, year;
year = 2023;
Console.Write("Пожалуйста, введите свой год рождения: ");
year_born = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вам " + (year - year_born) + " лет.");