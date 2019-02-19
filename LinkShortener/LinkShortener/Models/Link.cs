using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkShortener.Models
{
    public class Link
    {
        public long IdLink { get; set; }
        public string ShortLink { get; set; }
        public string FullLink { get; set; }
        public bool Status { get; set; }
        public long IdCreator { get; set; }
        public bool StatusBan { get; set; }
        public long VisitCount { get; set; }

    }
}