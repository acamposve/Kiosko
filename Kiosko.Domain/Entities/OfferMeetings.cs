using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain.Entities
{
    public class OfferMeetings
    {
        public int MeetingsId { get; set; }

        public int BinnacleId { get; set; }

        public int OffersId { get; set; }
    }
}
