using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GuestBookMVC.Clients.Web.Models
{
    public class GuestBookDbContext: DbContext
    {
        public DbSet<GuestBookEntry> entries { get; set; }
    }
}