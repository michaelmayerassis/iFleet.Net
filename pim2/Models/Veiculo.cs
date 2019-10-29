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
        public String Nome { get; set; }
        public String Cor { get; set; }
        public String Modelo { get; set; }
        public Int32 Ano { get; set; }
        public String Placa { get; set; }
        public String Renavan { get; set; }
        public String Marca { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
