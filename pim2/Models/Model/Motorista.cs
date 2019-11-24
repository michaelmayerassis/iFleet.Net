using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim2.Models
{
    [Table("Motorista")]
    public class Motorista
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string CPF { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string CNH { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria_Cnh { get; set; }


        [DataType(DataType.Date)]
        public DateTime Dt_Nascimento { get; set; }

        [Required]
        [StringLength(250)]
        public string Exame_medico { get; set; }

        [Required]
        [StringLength(250)]
        public string email { get; set; }

        [Required]
        [StringLength(150)]
        public string endereco { get; set; }

        [Required]
        public int numero { get; set; }

        [Required]
        [StringLength(150)]
        public string cidade { get; set; }

        [Required]
        [StringLength(150)]
        public string Bairro { get; set; }

        [Required]
        public int CEP { get; set; }
    }
}
