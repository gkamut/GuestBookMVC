using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBookMVC.Clients.Web.Models
{
    public class GuestBookEntry
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Website { get; set; }
        public virtual string Message { get; set; }
        public virtual DateTime InsertDate { get; set; }
    }
}