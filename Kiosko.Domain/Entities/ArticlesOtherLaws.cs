﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class ArticlesOtherLaws : BaseEntity
    {
        public int ArticleNumber { get; set; }


        public string FullTextArticle { get; set; }
        public string ResumeArticle { get; set; }
        public int ComparativeTitleId { get; set; }
        public string ComparativeField { get; set; }

        public string ArticleTitle { get; set; }
    }
}
