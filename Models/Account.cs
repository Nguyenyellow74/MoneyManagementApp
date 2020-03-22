namespace MoneyManagementWebApp.Models
{
    public class Account
    {
        public int ID { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}