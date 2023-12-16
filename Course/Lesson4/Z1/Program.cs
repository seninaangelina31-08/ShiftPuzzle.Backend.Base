int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;

        foreach (int num in arr)
        {
            sum += num;
        }

        Console.WriteLine("Сумма всех элементов в массиве: " + sum)