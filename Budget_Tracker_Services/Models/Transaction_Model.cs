namespace Budget_Tracker_Services.Models
{
    public class Transaction_Model
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal? BankCharge { get; set; }
        public int? TransactionTypeId { get; set; }
        public int? AccountId { get; set; }
        public int? BankId { get; set; }
        public int? ProductId { get; set; }
    }
}
