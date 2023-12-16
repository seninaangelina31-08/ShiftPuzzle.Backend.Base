int[] arr = { 5, 8, 3, 2, 9 };

Console.Write("\n Чётные числа: ");
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
            }
        }