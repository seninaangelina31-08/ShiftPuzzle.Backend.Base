namespace Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
public class StoreController : ControllerBase
{
    // Продукты
    private static readonly List<Product> Items = new List<Product>();
    // Пользователи
    private static readonly List<User> Users = new List<User>();

    // Обновление цены на продукт
    [HttpGet]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice(string name, double newPrice)
    {
        var product = Items.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            product.Price = newPrice;
            return Ok($"{name} обновлен с новой ценой: {newPrice}");
        }
        else
        {
            return NotFound($"Продукт {name} не найден");
        }
    }

    // Изменение названия продукта
    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName([FromBody] UpdateNameData updateNameData)
    {
        var product = Items.FirstOrDefault(p => p.Name == updateNameData.CurrentName);
        if (product != null)
        {
            product.Name = updateNameData.NewName;
            return Ok($"Имя продукта изменено с {updateNameData.CurrentName} на {updateNameData.NewName}");
        }
        else
        {
            return NotFound($"Продукт {updateNameData.CurrentName} не найден");
        }
    }

    // Получаем те продукты, которых нет в наличии
    [HttpGet]
    [Route("/store/outofstock")]
    public IActionResult OutOfStock()
    {
        var outOfStockItems = Items.Where(p => p.Stock == 0).ToList();
        if (outOfStockItems.Any())
        {
            return Ok(outOfStockItems);
        }
        else
        {
            return Ok("Все продукты в наличии");
        }
    }

    // Добавить новый продукт
    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add([FromBody] Product product)
    {
        Items.Add(product);
        return Ok(Items);
    }

    // Удалить продукт
    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete([FromBody] DeleteNameData deleteNameData)
    {
        var product = Items.FirstOrDefault(p => p.Name == deleteNameData.Name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{deleteNameData.Name} удален");
        }
        else
        {
            return NotFound($"{deleteNameData.Name} не найден");
        }
    }

    // Получить список продуктов
    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }

    // Добавить пользователя
    [HttpPost]
    [Route("/store/add_user")]
    public IActionResult AddUser([FromBody] User user)
    {
        // Добавляем нового пользователя
        Users.Add(user);
        return Ok($"User {user.Login} added.");

    }

    // Зарегестрировать пользователя
    [HttpPost]
    [Route("store/logining_user")]
    public IActionResult UserLogining([FromBody] User user)
    {
        foreach (var cur_user in Users)
        {
            // Если логин и пароль корректные
            if (cur_user.Login == user.Login && cur_user.Password == user.Password)
            {
                // Меняем статус пользователя на "зарегестрирован"
                cur_user.IsAuthorized = true;
                return Ok("Пользователь успешно зарегестрирован");
            }
        }
        return NotFound("Некорректный пароль или логин :(");
    }

    // Получить информацию о пользователе
    [HttpGet]
    [Route("/store/user_info")]
    public IActionResult UserInfo()
    {
        // Возвращаем информацию о пользователе
        return Ok(Users);
    }
}