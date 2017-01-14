using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projektKompo.Models
{
    public class RattingReview : IEnitity
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [Range(0, 10)]
        [Display(Name = "Ocena")]
        public int Ratting { get; set; }

        [MaxLength(500, ErrorMessage = "{0} powinien posiadać maksymalnie 500 znaków.")]
        [Display(Name = "Komentarz")]
        public string Comment { get; set; }
        public int ReviewId { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }
    }
}