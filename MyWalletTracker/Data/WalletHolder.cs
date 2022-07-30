using Microsoft.AspNetCore.Identity;

namespace MyWalletTracker.Data
{
    public class WalletHolder : IdentityUser
    {
        public string Name { get; set; }
    }
}
