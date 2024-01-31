Привет! Тебе предстоить сделать рефакторинг проекта с предыдшуего урока. 

---
# Практика А:

1. Рефакторинг серверной части [Server/StoreController.cs]
  -  В функции [WriteDataToFile] вынести работу с json в отдельную функцию    [ConvertDBtoJson]
<<<<<<< HEAD
  -  В функции [WriteDataToFile] вынести работу с файлом в отдельную функцию  [WriteToDB]
=======
  -  В функции [WriteDataToFile] вынести работу с файлом в отдельную функцию  [WriteTiDB]
>>>>>>> 142dd57b (Create Tasks.md)


---
# Практика В: 

1. Рефакторинг серверной части [Server/StoreController.cs]

<<<<<<< HEAD
  -  В функции [ReadDataFromFile] вынести работу с json в отдельную функцию                [ConvertTextDBToList]
  -  В функции [ReadDataFromFile] вынести работу с файлом в отдельную функцию              [ReadDB]
  -  В функции [ReadDataFromFile] вынести проверку сущестования файла в отдельную функцию  [DBExist] 
=======
  -  В функции [WriteDataToFile] вынести работу с json в отдельную функцию                [ConvertTextDBToList]
  -  В функции [WriteDataToFile] вынести работу с файлом в отдельную функцию              [ReadDB]
  -  В функции [WriteDataToFile] вынести проверку сущестования файла в отдельную функцию  [DBExist] 
>>>>>>> 142dd57b (Create Tasks.md)

---
# Практика C:

1.   Рефакторинг клиентской части [Client/Program.cs]
<<<<<<< HEAD
  - вынести адрес, порт и название методов в константы
=======
  - вынести адрес,порт и название методов в константы
>>>>>>> 142dd57b (Create Tasks.md)
    > подсказка
      ```C# const url = "http://localhost" ```
      ```C# const port = "5087" ``` 
      ```C# const AddProductMethod = "/store/add" ```