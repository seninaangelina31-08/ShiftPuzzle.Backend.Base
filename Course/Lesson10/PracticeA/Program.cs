<<<<<<< HEAD
﻿namespace PracticeA;
=======
﻿using System;
using System.IO;

namespace PracticeA;
>>>>>>> d0b1f546 (feat: added answer to task 10)
class FileOperations
{
    static void Main(string[] args)
    { 

<<<<<<< HEAD
=======
        string fp = "test.txt";

            // Writing to the file
        string write = "Meooooooooooooooooooooooooow heheheh";
        File.WriteAllText(fp, write);

            // Reading from the file
        string read = File.ReadAllText(fp);
        Console.WriteLine(read);
>>>>>>> d0b1f546 (feat: added answer to task 10)
        // чтение запись в файл test.txt
    }
}
