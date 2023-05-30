using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class CompanyOffers
    {
        public int OfferId { get; set; }

        public int BinnacleId { get; set; }

        public string OfferNumber { get; set; }

        public string OfferFullText { get; set; }

        public string StatusOffer { get; set; }

        public int ComparativeTitleId { get; set; }

        public int RequestId { get; set; }

        public string OfferTitle { get; set; }
    }
}
