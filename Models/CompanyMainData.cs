using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net5RazorPagesExample.Models
{
    public class CompanyMainData
    {
        public int Id { get; set; }
        [Required]
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
    }
}
