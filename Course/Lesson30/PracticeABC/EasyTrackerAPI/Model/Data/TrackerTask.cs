
//2. Расширить описание класса "Задача":
//    - ИД (уже есть)
//    - ИМЯ
//    - ОПИСАНИЕ
 //   - ЗАВЕРШЕНО/НЕ ЗАВЕРШЕНО
 //   - ДАТА ЗАВЕРШЕНИЯ
 //   - ЗАКРЕПЛЕННЫЙ ПОЛЬЗОВАТЕЛЬ
public class TrackerTask
{  
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; } 
    public DateTime? Data { get; set; } 
     
    public User? Userpinned { get; set; } 
}
 