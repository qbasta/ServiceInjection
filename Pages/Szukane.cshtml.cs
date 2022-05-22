using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceInjection.Interfaces;
using ServiceInjection.Models;
using ServiceInjection.ViewModels.User;

namespace ServiceInjection.Pages
{
    public class SzukaneModel : PageModel
    {

        private readonly IUserService _userService;

        public ListUserViewModel Records { get; set; }

        public SzukaneModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
            Records = _userService.GetPeople();
        }
    }
}
