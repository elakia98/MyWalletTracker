using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWalletTracker.Data
{
    [Keyless]
    public class WalletDetails
    {
        public DateTime AddedDate { get; set; }
        public string Description { get; set; }

        [ForeignKey("ExpenseTypeName")]
        public ExpenseType ExpenseType { get; set; }
        public string ExpenseTypeName { get; set; }

        public int Amount { get; set; }

    }
}
