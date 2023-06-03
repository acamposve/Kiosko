using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain.Entities
{
    public class RequestMeetings
    {
        public int MeetingsId { get; set; }

        public int BinnacleId { get; set; }

        public int RequestsId { get; set; }
    }
}
