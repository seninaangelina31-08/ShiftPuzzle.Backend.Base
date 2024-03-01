class ProgramPrB
{
    static async Task Main(string[] args)
    {
        string url = "https://emojiisland.com/cdn/shop/products/Emoji_Icon_-_Clown_emoji_large.png";
        string localFilePath = "clown.png";
        await DownloadFileAsync(url, localFilePath);


        string filePath = "input.txt";
        await WriteToFileAsync(filePath, "Привет, мир!");
        await ReadFromFileAsync(filePath);


        List<string> urls = new() { "http://google.com", "http://yandex.ru", "http://yahoo.com" };
        await FetchDataAsync(urls);


    }

    static async Task DownloadFileAsync(string url, string filePath)
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode) //проверка успешности запроса
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await response.Content.CopyToAsync(fileStream); // сохранение файла
                }
            }
            else
            {
                Console.WriteLine("Ошибка загрузки файла.");
            }
        }
    }

    static async Task WriteToFileAsync(string filePath, string content)
    {
        using (var writer = new StreamWriter(filePath))
        {
            await File.WriteAllTextAsync(filePath, content); // запись в файл асинхронно
        }
        Console.WriteLine("Файл успешно записан.");
    }

    static async Task ReadFromFileAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            string readedText = await File.ReadAllTextAsync(filePath);
        }
        Console.WriteLine("Данные успешно прочитаны");
    }

    static async Task FetchDataAsync(List<string> urls)
    {
        using (var httpClient = new HttpClient())
        {
            List<string> content = new();
            foreach (string url in urls)
            {
                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode) //проверка успешности запроса
                {
                    content.Add(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    Console.WriteLine("Ошибка получения данных по API.");
                }
            }
        }
    }


}
