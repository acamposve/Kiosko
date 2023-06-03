using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Users : BaseEntity
    {

        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompanyId { get; set; }

        public int UserTypeId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
    }
}
