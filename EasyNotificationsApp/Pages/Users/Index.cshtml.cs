#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EasyNotificationsApp.Data;
using EasyNotificationsApp.Models;

namespace EasyNotificationsApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly EasyNotificationsApp.Data.EasyNotificationsAppContext _context;

        public IndexModel(EasyNotificationsApp.Data.EasyNotificationsAppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
