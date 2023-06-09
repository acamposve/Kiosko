﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class ContractAttachments : BaseEntity
    {


        public int ContractId { get; set; }

        public string? AttachmentName { get; set; }

        public string? AtachmentDescription { get; set; }

        public string? AttachmentFullText { get; set; }

        public string? AttachmentPdf { get; set; }

        public string? PublicationStatus { get; set; }


    }
}
