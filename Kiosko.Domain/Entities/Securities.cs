using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Securities : BaseEntity
    {
        public int UsersTypesId { get; set; }

        public int? ScreenId { get; set; }

    }
}
