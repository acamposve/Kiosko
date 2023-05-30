using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class News : BaseEntity
    {


        public string Abstract { get; set; }

        public string FullText { get; set; }

        public int? CategoryId { get; set; }

        public string Title { get; set; }

        public DateTime? PublicationDate { get; set; }

        public string Status { get; set; }

        public string Image1 { get; set; }

        public string Image2 { get; set; }

        public string Origen { get; set; }
    }
}
