using Microsoft.AspNetCore.Mvc;

namespace backend_scrumplace.src.Login
{
    public interface ILoginService
    {
        IActionResult Login();
    }
}
