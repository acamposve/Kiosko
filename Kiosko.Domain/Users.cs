using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public  class Users : BaseEntity
    {

        public string Login { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }

        public int UserTypeId { get; set; }
        public string Address  { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
    }
}
