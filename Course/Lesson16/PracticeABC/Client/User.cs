using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client
{
    public class StoreUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAuthorized { get; set; }

        public StoreUser(string login, string password, bool isAuthorized = false)
        {
            this.Login = login;
            this.Password = password;
            this.IsAuthorized = isAuthorized;
        }
        public void Authorize()
        {
            this.IsAuthorized = true;
        }
    }
}