Привет! Тебе предстоить сделать рефакторинг проекта с предыдшуего урока. 

---
# Практика А:

<<<<<<< HEAD
1. Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]
  -  создать класс модели и перенести работу с базой данных
=======
1. Рефакторинг серверной части [Server/StoreController.cs]
  -  В функции [WriteDataToFile] вынести работу с json в отдельную функцию    [ConvertDBtoJson]
  -  В функции [WriteDataToFile] вынести работу с файлом в отдельную функцию  [WriteTiDB]
>>>>>>> 2f0ac98b (Материалы 19-го урока)


---
# Практика В: 

<<<<<<< HEAD
1. Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]

  - прокинуть связь между контроллером и моделью
  - сделать вызов из контроллера
=======
1. Рефакторинг серверной части [Server/StoreController.cs]

  -  В функции [WriteDataToFile] вынести работу с json в отдельную функцию                [ConvertTextDBToList]
  -  В функции [WriteDataToFile] вынести работу с файлом в отдельную функцию              [ReadDB]
  -  В функции [WriteDataToFile] вынести проверку сущестования файла в отдельную функцию  [DBExist] 
>>>>>>> 2f0ac98b (Материалы 19-го урока)

---
# Практика C:

<<<<<<< HEAD
1.   Рефакторинг серверной части [Server/StoreController.cs] [Server/DBModel.cs]

- создать функцию бекапа для БД в отдельную базу ["BackupDB.json"]
=======
1.   Рефакторинг клиентской части [Client/Program.cs]
  - вынести адрес,порт и название методов в константы
    > подсказка
      ```C# const url = "http://localhost" ```
      ```C# const port = "5087" ``` 
      ```C# const AddProductMethod = "/store/add" ```
>>>>>>> 2f0ac98b (Материалы 19-го урока)
