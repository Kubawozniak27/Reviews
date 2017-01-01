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
        public int CategoryId { get; set; }
        public virtual ICollection<RattingReview> RattingReview { get; set; }
    }
}