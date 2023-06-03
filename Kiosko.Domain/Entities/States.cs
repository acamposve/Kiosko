using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class States : BaseEntity
    {


        public int CountryId { get; set; }

        public string Name { get; set; }

    }
}
