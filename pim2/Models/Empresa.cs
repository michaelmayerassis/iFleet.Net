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
        public String nome { get; set; }
        public String CNPJ { get; set; }
        public String telefone { get; set; }
        public String email { get; set; }
        public String endereco { get; set; }
        public int numero { get; set; }
        public String cidade { get; set; }
        public String bairro { get; set; }
    }
}
