using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Screens : BaseEntity
    {


        public string Name { get; set; }

        public string Url { get; set; }

        public int Priority { get; set; }

        public int ModuleId { get; set; }
    }
}
