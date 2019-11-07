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
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string CNH { get; set; }
        public string Categoria_Cnh { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string Exame_medico { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
    }
}
