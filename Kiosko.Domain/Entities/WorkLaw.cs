using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class WorkLaw : BaseEntity
    {

        public string PublishDate { get; set; }

        public string Pdf { get; set; }

        public string Abstract { get; set; }

        public int TotalArticles { get; set; }
    }
}
