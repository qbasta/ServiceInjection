using ServiceInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceInjection.ViewModels.User;
using ServiceInjection.Interfaces;
using ServiceInjection.Interfaces;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IUserService _userService;

    public ListUserViewModel Records { get; set; }
    public string Result { get; set; }

    [BindProperty]
    public User User { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    public void OnGet()
    {
        Records = _userService.GetTodayPeople();
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            Result = $"{User.Name} urodził/a się w {User.Year} roku. ";
            if (User.IsLeapYear())
                Result += "- rok przestępny.";
            else
                Result += "- rok nieprzestępny.";

            if (User.Surname != null)
            {
                User.Result = User.IsLeapYear();
                User.CreatedTime = DateTime.Now;

                _userService.Insert(User);
            }
        }
        Records = _userService.GetTodayPeople();

        return Page();
    }
}
