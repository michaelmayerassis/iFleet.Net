using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    [Table("Peca")]
    public class Peca
    {
        [Required]
        [Display(Name = "Nome"), StringLength(50)]
        public string Nome { get; set; }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Display(Name = "Prateleira")]
        [StringLength(10)]
        public string Prateleira { get; set; }

        [Display(Name = "Quantidade para Estoque")]
        public int? Quantidade { get; set; }

        [Display(Name = "Quantidade minima para estoque")]
        public int? EstoqueMinimo { get; set; }

        public decimal Valor { get; set; }
    }
}
