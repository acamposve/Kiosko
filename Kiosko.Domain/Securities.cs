using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class Securities : BaseEntity
    {
        public int UsersTypesId { get; set; }

        public int? ScreenId { get; set; }

    }
}
