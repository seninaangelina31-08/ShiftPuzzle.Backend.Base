GetAllTasks:
- Метод: GET
- URL: /api/tasks/getall
- Описание: Возвращает все задачи из базы данных в виде коллекции IEnumerable<TrackerTask>.
GetByID:
- Метод: GET
- URL: /api/tasks/get/{id}
- Описание: Возвращает задачу с указанным ID из базы данных. Метод возвращает объект TrackerTask.
AddTaskk:
- Метод: POST
- URL: /api/tasks/add
- Описание: Добавляет новую задачу в базу данных. Принимает данные задачи через тело запроса.
DeleteTaskk:
- Метод: GET
- URL: /api/tasks/delete/{id}
- Описание: Удаляет задачу с указанным ID из базы данных.
AddRandomTask:
- Метод: GET
- URL: /api/tasks/addrandom/{id}
- Описание: Генерирует случайное количество новых задач с увеличивающимися ID и добавляет их в базу данных.