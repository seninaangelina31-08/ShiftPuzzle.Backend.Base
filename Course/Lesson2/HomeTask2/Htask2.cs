//Загадайте случайное число в переменной и попросите пользователя угадать это число, предоставляя подсказки (больше/меньше).   
Console.Write("Введите число: ");
int x = 5;
int d = Convert.ToInt32(Console.ReadLine());
while (d!=x){
    Console.Write("Это число меньше 6 но больше 3 ");
    int f = Convert.ToInt32(Console.ReadLine());
    d = f;
}
Console.WriteLine("Верно!");