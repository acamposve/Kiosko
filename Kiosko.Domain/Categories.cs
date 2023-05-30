using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class Categories : BaseEntity
    {


        public string Name { get; set; }

        public string Image { get; set; }

        public int? Priority { get; set; }

        public string Description { get; set; }
    }
}
