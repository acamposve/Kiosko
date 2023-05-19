using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class Titles : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryTitleId { get; set; }
    }
}
