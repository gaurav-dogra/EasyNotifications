#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyNotificationsApp.Models;

namespace EasyNotificationsApp.Data
{
    public class EasyNotificationsAppContext : DbContext
    {
        public EasyNotificationsAppContext (DbContextOptions<EasyNotificationsAppContext> options)
            : base(options)
        {
        }

        public DbSet<EasyNotificationsApp.Models.User> User { get; set; }
    }
}
