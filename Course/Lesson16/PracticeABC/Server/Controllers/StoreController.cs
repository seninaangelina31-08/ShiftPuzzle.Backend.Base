namespace L16
{
    using Microsoft.AspNetCore.Mvc;
    [ApiController]
    public class StoreController : ControllerBase
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }

            public Product(string name, double price, int stock)
            {
                Name = name;
                Price = price;
                Stock = stock;
            }
        }


        public class User
        {
            public string name { get; set; }
            public double password { get; set; }
            public bool isAuthorized { get; set; }

            public User() { }
            public User(string name, double password, bool isAuthorized)
            {
                this.name = name;
                this.password = password;
                this.isAuthorized = false;
            }
        }
        private static readonly List<Product> Items = new List<Product>();
        private static readonly List<User> Users = new List<User>();

        [HttpGet]
        [Route("/store/updateprice")]
        public IActionResult UpdatePrice(string name, double newPrice)
        {
            var product = Items.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                product.Price = newPrice;
                return Ok($"{name} - новая цена {newPrice}");
            }
            else
            {
                return NotFound($" {name} не найден");
            }
        }
        // PracticeA
        [HttpPost]
        [Route("/store/add")]
        public IActionResult Add([FromBody] Product newProduct)
        {
            Items.Add(newProduct);
            return Ok(Items);
        }

        [HttpPost]
        [Route("/store/delete")]
        public IActionResult Delete(string name)
        {
            foreach (var prod in Items)
            {
                if (prod.Name == name)
                {
                    Items.Remove(prod);
                    return Ok(Items);
                }
            }
            return NotFound("Продукт не найден");
        }
        [HttpGet]
        [Route("/store/show")]
        public IActionResult Show()
        {
            return Ok(Items);
        }
        // PracticeB
        [HttpPost]
        [Route("/store/add_user")]
        public IActionResult AddUser([FromBody] User user)
        {
            Users.Add(user);
            return Ok($"{user.name} был добавлен");
        }

        [HttpPost]
        [Route("/store/login")]
        public IActionResult Login([FromBody] User user)
        {
            foreach (var us in Users)
            {
                if (us.name == user.name)
                {
                    if (us.password == user.password)
                    {
                        user.isAuthorized = true;
                        return Ok("Всё кус!!!");
                    }
                }
            }
            return NotFound("Что-то не так");
        }

        //PracticeC
        [HttpPost]
        [Route("/store/updatename")]
        public IActionResult UpdateName(string currentName, string newName)
        {
            foreach (var prod in Items)
            {
                if (prod.Name == currentName)
                {
                    prod.Name = newName;
                    return Ok(Items);
                }
            }
            return NotFound("Продукт не найден");
        }

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
                return Ok("Всё в наличии");
            }
        }
    }
}