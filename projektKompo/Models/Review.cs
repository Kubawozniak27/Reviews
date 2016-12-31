using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projektKompo.Models
{
    public class Review : IEnitity
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<RattingReview> RattingReview { get; set; }
    }
}