using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projektKompo.ViewModels
{
    public class CreateReviewViewModel
    {
        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [MinLength(2, ErrorMessage = "{0} powinien posiadać co najmniej 2 znaki.")]
        [MaxLength(100, ErrorMessage = "{0} powinien posiadać maksymalnie 100 znaków.")]
        [Display(Name = "Tytuł")]
        public string Tittle { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [MinLength(50, ErrorMessage = "{0} powinien posiadać co najmniej 50 znaki.")]
        [MaxLength(1500, ErrorMessage = "{0} powinien posiadać maksymalnie 1500 znaków.")]
        [Display(Name = "Opis recenzji")]
        public string Description { get; set; }

        public string Author { get; set; }
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}