using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.Common.Enums
{
    public enum LinkStatus
    {
        None = 0,
        SwitchedOn = 1,
        SwitchedOff = 2,
        Broken = 3,
        Blocked = 4,
    }
}
