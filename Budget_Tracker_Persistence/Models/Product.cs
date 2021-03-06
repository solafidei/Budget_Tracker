// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

namespace Budget_Tracker_Persistence.Models
{
    public partial class Product
    {
        public Product()
        {
            Account = new HashSet<Account>();
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BankId { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}