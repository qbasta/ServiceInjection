using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceInjection.Data;
using ServiceInjection.Models;

namespace ServiceInjection.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly ServiceInjection.Data.PeopleContext _context;

        public IndexModel(ServiceInjection.Data.PeopleContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
