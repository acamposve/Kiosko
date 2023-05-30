using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class Contracts : BaseEntity
    {


        public string PdfAutoActa { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Duration { get; set; }

        public string ScopeAplication { get; set; }

        public int CompanyId { get; set; }

        public string PublicationStatus { get; set; }
    }
}
