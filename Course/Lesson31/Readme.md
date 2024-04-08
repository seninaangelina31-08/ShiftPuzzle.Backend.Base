GetAll:
- Метод: GET
- URL: /api/tasks/getall
- Описание: Возвращает все задачи из базы данных в виде коллекции IEnumerable<TrackerTask>.
Get:
- Метод: GET
- URL: /api/tasks/get/{id}
- Описание: Возвращает задачу с указанным ID из базы данных. Метод возвращает объект TrackerTask.

Delete:
- Метод: GET
- URL: /api/tasks/delete/{id}
- Описание: Удаляет задачу с указанным ID из базы данных.
AddRandomTask:
- Метод: GET
- URL: /api/tasks/addrandom/{id}
- Описание: Генерирует случайное количество новых задач с увеличивающимися ID и добавляет их в базу данных.
Create:
- HTTP Метод: POST
- Маршрут: /api/tasks/add
- Описание: Этот метод создает новую задачу, принимая объект TrackerTask в теле запроса и вызывая метод _taskManager.AddTask(task) для добавления задачи.
