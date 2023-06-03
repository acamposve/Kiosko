using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kiosko.Domain.Common;

namespace Kiosko.Domain.Entities
{
    public class ArticlesContracts : BaseEntity
    {
        public int ContractId { get; set; }
        public int ArticlesQuantity { get; set; }

        public string FullTextArticle { get; set; }
        public string ResumeArticle { get; set; }
        public int ComparativeTitleId { get; set; }
        public string ComparativeField { get; set; }
        public string ArticleStatus { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleClosed { get; set; }
    }
}
