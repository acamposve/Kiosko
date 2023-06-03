using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Agreements : BaseEntity
    {

        public int BinnacleId { get; set; }

        public int RequestId { get; set; }

        public int OfferId { get; set; }

        public int MeetingId { get; set; }

        public string? AgreementDate { get; set; }

        public string? ArticleNumber { get; set; }

        public string? FullTextArticle { get; set; }

        public string? AbstractArticle { get; set; }

        public int ComparativeTitleCode { get; set; }

        public string? ComparativeField { get; set; }

        public string? AgreementStatus { get; set; }

        public string? ArticleTitle { get; set; }
    }
}
