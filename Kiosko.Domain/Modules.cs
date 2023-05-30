using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class Modules : BaseEntity
    {


        public string Name { get; set; }

        public int? Priority { get; set; }

        public int CategoryId { get; set; }

        public string Url { get; set; }
    }
}
