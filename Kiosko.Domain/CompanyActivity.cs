using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class CompanyActivity : BaseEntity
    {
        public string? ActivityName { get; set; }
        public string? ActivityDescription { get; set; }
    }
}
