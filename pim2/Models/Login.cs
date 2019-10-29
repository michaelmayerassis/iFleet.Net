using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Empresa"), StringLength(50, MinimumLength = 1)]
        public string usuario { get; set; }
        [Required]
        [Display(Name = "Senha"), StringLength(50, MinimumLength = 1)]
        public string senha { get; set; }
    }
}
