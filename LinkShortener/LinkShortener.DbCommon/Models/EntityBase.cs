using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortener.DbCommon.Models
{
    public abstract class EntityBase
    {
        public long Id { get; set; }
    }
}
