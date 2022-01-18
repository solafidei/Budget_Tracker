namespace Budget_Tracker_Services.Models
{
    public class Account_Model
    {
        public int Id { get; set; }
        public int AccountNumber { get; set; }
        public decimal RunningBalance { get; set; }
        public int? ProductId { get; set; }
        public Product_Model Product { get; set; }
    }
}
