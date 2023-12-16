int[] arr = { 5, -8, 3, -2, 9 };

int count = 0;
        foreach (int num in arr)
        {
            if (num < 0)
            {
                count++;
            }
        }

        Console.Write("\n Количество отрицательных чисел: " + count);