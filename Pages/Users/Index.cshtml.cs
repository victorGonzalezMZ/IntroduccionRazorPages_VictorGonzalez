using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IntroduccionRazorPages.Data;
using IntroduccionRazorPages.Models;

namespace IntroduccionRazorPages.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IntroduccionRazorPages.Data.IntroduccionRazorPagesContext _context;

        public IndexModel(IntroduccionRazorPages.Data.IntroduccionRazorPagesContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            //User = await _context.User.ToListAsync();

            var users = from m in _context.User select m;

            if (!string.IsNullOrEmpty(SearchString))
                users = users.Where(s => s.Username.Contains(SearchString));

            User = await users.ToListAsync();
        }
    }
}
