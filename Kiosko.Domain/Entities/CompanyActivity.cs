using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class CompanyActivity : BaseEntity
    {
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
    }
}
