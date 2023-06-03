using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Meetings : BaseEntity
    {


        public int BinnacleId { get; set; }

        public DateTime MeetingDate { get; set; }


        public string MeetingDuration { get; set; }

        public string MeetingExtract { get; set; }

        public string MeetingDetails { get; set; }

        public string MeetingAtendees { get; set; }
    }
}
