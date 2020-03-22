using System.Collections.Generic;

namespace MoneyManagementWebApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}