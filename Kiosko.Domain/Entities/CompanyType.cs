using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class CompanyType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
