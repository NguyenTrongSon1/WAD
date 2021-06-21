using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace T2004E_WAD.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Vui long dien day du thong tin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui long dien day du thong tin")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Vui long dien day du thong tin")]
        public string Description { get; set; }
    }
}