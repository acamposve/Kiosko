﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosko.Domain
{
    public class OtherLaws : BaseEntity
    {


        public string Name { get; set; }

        public string PublishDate { get; set; }

        public string Description { get; set; }

        public string Pdf { get; set; }

        public int TotalArticles { get; set; }

        public string Origen { get; set; }
    }
}
