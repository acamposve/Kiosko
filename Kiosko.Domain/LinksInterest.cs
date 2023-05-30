using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class LinksInterest : BaseEntity
    {


        public int SectorId { get; set; }

        public string Detail { get; set; }

        public string Link { get; set; }
    }
}
