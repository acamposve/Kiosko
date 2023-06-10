using Kiosko.Domain.Common;
using Kiosko.Domain.Entities;

namespace Kiosko.Domain.Events
{
    public class CompanyActivityCreatedEvent : BaseEvent
    {
        public CompanyActivityCreatedEvent(CompanyActivity item)
        {
            Item = item;
        }

        public CompanyActivity Item { get; }
    }
}
