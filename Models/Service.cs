using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net5RazorPagesExample.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        [Required]
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
       
    }
}
