string name, number;
Console.Write("Введите имя пользователя: "); name = Console.ReadLine() ?? "Noname"; Console.Write("Введите номер телефона пользоватля: "); number = Console.ReadLine() ?? "0";
Console. WriteLine("Пользователь: " + name + " добавлен в  контакты. Его номер телефона: " + number);