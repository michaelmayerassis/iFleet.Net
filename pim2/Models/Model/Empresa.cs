using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public String nome { get; set; }

        [Required]
        [StringLength(14, MinimumLength = 14)]
        public String CNPJ { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        public String telefone { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        [StringLength(250)]
        public String email { get; set; }

        [Required]
        [StringLength(250)]
        public String endereco { get; set; }

        [Required]
        public int numero { get; set; }

        [Required]
        [ StringLength(200)]
        public String cidade { get; set; }

        [Required]
        [ StringLength(200)]
        public String bairro { get; set; }

        [Required]
        [ StringLength(50)]
        public String senha { get; set; }
    }
}
