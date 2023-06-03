using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class LinksInterest : BaseEntity
    {


        public int SectorId { get; set; }

        public string Detail { get; set; }

        public string Link { get; set; }
    }
}
