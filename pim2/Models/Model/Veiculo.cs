using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pim2.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public Int32 Id { get; set; }

        [ForeignKey("Empresa")]
        public Int32 Empresa_Id { get; set; }

        [Required]
        [Display(Name = "Nome"), StringLength(50, MinimumLength = 1)]
        public String Nome { get; set; }

        [Required]
        public String Cor { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 4)]
        public String Modelo { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 4)]
        public Int32 Ano { get; set; }

        [Required]
        [StringLength(7, MinimumLength = 7)]
        public String Placa { get; set; }

        [Required]
        [StringLength(50)]
        public String Renavan { get; set; }

        [Required]
        [StringLength(50)]
        public String Marca { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
