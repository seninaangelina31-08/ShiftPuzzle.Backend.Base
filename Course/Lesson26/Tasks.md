Привет! Тебе предстоить сделать рефакторинг проекта с предыдшуего урока. 

---
# Практика А:

1. Переделать результат практики AB предыдщего урока с новыми треобованиями (передать сообщение в качестве параметра в каждый метод)

--- 
# Практика B: 

1.  Добавить в решение событие завершение доставки (реализовать по аналогии с методами TestNewMsg и TestNewOreder)

> Подсказка: 
```C#
    public static async Task TestOrderDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time {dateTime}");
    }
```

--- 
# Практика C:

1. Добавить в решение с СУБД события с передаваемым типом 
 
- методы не надо реализовывать на 100%, достачтоно мокать (зашлушка)
>> ПРИМЕР (нужно для всех методов):

```C#
        private void SendNotificationToStatDepartmetn(Product product)
        {
           Console.WriteLine("Отправляю отчет в отдел статистики...");
           Console.WriteLine($"Добавлен новый продукт: {product.Name}");    
        }
```