using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.GuiCommon.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Link> links { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
