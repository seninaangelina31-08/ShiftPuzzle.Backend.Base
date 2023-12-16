int[] arr = { 5, 8, 3, 2, 9 };
        int max = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("Максимальное значение в массиве: " + max);