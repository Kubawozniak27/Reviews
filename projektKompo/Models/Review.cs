using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projektKompo.Models
{
    public class Review : IEnitity
    {
        [Display(Name ="Tytuł")]
        public string Tittle { get; set; }

        [Display(Name ="Opis recenzji")]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string Author { get; set; }C:\Users\Kuba\Desktop\projektKompo\projektKompo\projektKompo\Models\IdentityModels.cs

        public virtual ICollection<RattingReview> RattingReview { get; set; }
    }
}