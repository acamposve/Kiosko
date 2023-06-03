using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Categories : BaseEntity
    {


        public string Name { get; set; }

        public string Image { get; set; }

        public int? Priority { get; set; }

        public string Description { get; set; }
    }
}
