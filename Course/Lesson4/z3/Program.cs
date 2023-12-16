int[] arr = { 5, 8, 3, 2, 9 };

int[] reversedArr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            reversedArr[i] = arr[arr.Length - 1 - i];
        }

        Console.Write("\ Перевёрнутый массив: ");
        foreach (int num in reversedArr)
        {
            Console.Write(num + " ");
        }