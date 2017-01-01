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
        [Display(Name ="Tytuł")]
        public string Tittle { get; set; }

        [Display(Name ="Opis recenzji")]
        public string Description { get; set; }

        public string Author { get; set; }
        [Display(Name ="Kategoria")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}