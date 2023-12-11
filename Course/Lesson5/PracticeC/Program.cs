int[] array = {4, 2, 0, 1, 2, 3, 1, 5, 0}; // Инициализируем массив
int position = 0; // Устанавливаем начальную позицию
int steps = array[0]; // Устанавливаем начальное количество шагов

while (position <= array.Length | position > array.Length | array[position] == 0)
{
    if (array[position] != 0)
    {
        steps = array[position];
        position += array[position];
    }
    else
    {
        Console.WriteLine("Невозможно достичь конца пути!");
        return;
    }
    
}

Console.WriteLine($"Сделано шагов {steps}");