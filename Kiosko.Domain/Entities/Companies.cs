using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class Companies : BaseEntity
    {

        public string? Name { get; set; }

        public string CompanyAddress { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        public string CompanyPhone { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyUrl { get; set; }

        public string CompanyRut { get; set; }



        public string CompanyContact { get; set; }

        public string ContactPosition { get; set; }

        public string ContaqtPhone { get; set; }

        public string ContactEmail { get; set; }

        public int SectorId { get; set; }

        public int TypeId { get; set; }

        public int CategoryId { get; set; }

        public int ActivityId { get; set; }

        public int QuantityWorkersCompany { get; set; }

        public int QuantityEmployeesCompany { get; set; }

        public string CompanySize { get; set; }

        public string Origen { get; set; }

        public string Logo { get; set; }
    }
}
