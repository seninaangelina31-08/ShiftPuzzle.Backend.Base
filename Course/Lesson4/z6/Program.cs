int[] arr = { 5, -8, 3, -2, 9 };
        int target = 3;


int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            Console.Write("\n Элемент " + target + " найден в массиве на позиции " + index);
        }
        else
        {
            Console.Write("\n Элемент " + target + " не найден в массиве");
        }

