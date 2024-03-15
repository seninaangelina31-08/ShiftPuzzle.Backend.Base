using System;
using System.Timers;
using System.Threading.Tasks;

class Program
{
      //Создать приложение которое будет создавать 3 потока для чтения и записи в файл.
 //- 1 поток будет делать резеверное копирование текстового файла
 //- 2 поток будет менять данные 
 //- 3 поток будет перезаписывать данные внутри
 static async Task Main()
    {
        string filepath = "murmur.txt";
        string backup = "meoww.txt";
        if (!File.Exists(backup))
        {
            using (File.Create(backup)) { }
        }

        Task<string> fileContentTask = Task.Run(() => File.ReadAllText(filepath));

        Task[] tasks = new Task[]
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    string content = await fileContentTask;
                    File.Copy(filepath, backup, true);
                    await Task.Delay(5000);
                }
            }),

            Task.Run(async () =>
            {
                while (true)
                {
                    string content = await fileContentTask;
                    File.AppendAllText(filepath, "Данные изменены\n");
                    await Task.Delay(3000);
                }
            }),

            Task.Run(async () =>
            {
                while (true)
                {
                    string content = await fileContentTask;
                    File.WriteAllText(filepath, " Данные перезаписаны");
                    await Task.Delay(6000);
                }
            })
        };
        await Task.WhenAll(tasks); 
    }
}    