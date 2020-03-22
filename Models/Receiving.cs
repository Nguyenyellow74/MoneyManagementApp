using System;
using System.ComponentModel.DataAnnotations;

namespace MoneyManagementWebApp.Models
{
    public class Receiving
    {
        public int ID { get; set; }
        public virtual Account Account { get; set; }
        public virtual Reason Reason { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }
    }
}