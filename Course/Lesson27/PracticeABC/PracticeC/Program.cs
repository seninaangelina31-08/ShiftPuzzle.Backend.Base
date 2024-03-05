using System.Diagnostics;



static async Task MakeCopyFileAsync(string path)
{
    string[] lines = await File.ReadAllLinesAsync(path);
    await File.WriteAllLinesAsync($"{path}_backup", lines);
}

static async Task ChangeInfoAsync()
{
    Console.WriteLine("Изменяю данные....");
    await Task.Delay(3000);
    Console.WriteLine("Данные изменены");
}

static async Task ChangeExtraInfoAsync()
{
    Console.WriteLine("Изменяю данные внутри....");
    await Task.Delay(3000);
    Console.WriteLine("Данные внутри - изменены");
}




await Task.Run(async () => await MakeCopyFileAsync("text.txt"));

await Task.Run(ChangeInfoAsync);

await Task.Run(ChangeExtraInfoAsync);

