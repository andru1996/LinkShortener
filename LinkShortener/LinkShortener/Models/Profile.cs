using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkShortener.Models
{
    public class Profile
    {
        public long IdCreator { get; set; }
        public string name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
        public bool StatusBan { get; set; }
    }
}