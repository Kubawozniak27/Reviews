using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projektKompo.Models
{
    public class RattingReview : IEnitity
    {
        [Range(0, 10)]
        public int Ratting { get; set; }
        public string Comment { get; set; }
        public int ReviewId { get; set; }
        public string Author { get; set; }
    }
}