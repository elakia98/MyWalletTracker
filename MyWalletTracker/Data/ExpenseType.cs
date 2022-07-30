using System.ComponentModel.DataAnnotations;

namespace MyWalletTracker.Data
{
    public class ExpenseType
    {
        [Key]
        public string Name { get; set; }
    }
}
