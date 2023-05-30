using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class Cities: BaseEntity
    {
        

        public int StateId { get; set; }

        public string? Name { get; set; }
    }
}
