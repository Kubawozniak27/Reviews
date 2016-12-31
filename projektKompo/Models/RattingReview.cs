using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projektKompo.Models
{
    public class RattingReview
    {
        public string Comment { get; set; }
        public virtual Review Review { get; set; }
    }
}