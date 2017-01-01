using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projektKompo.Models
{
    public class Category : IEnitity
    {
        [Display(Name="Nazwa kategorii")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}