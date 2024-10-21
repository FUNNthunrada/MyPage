using Microsoft.AspNetCore.Identity;

namespace MyPage.Models;

public class Users : IdentityUser
{
    public string FirstName { get; set; }
}
