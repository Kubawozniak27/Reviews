using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projektKompo.ViewModels
{
    public class CreateReviewViewModel
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}