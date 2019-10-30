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
        private String _nome;
        [Required]
        [Display(Name = "Nome"), StringLength(50, MinimumLength = 1)]
        public string Nome
        {
            get => _nome;
            set
            {
                if (IsNull(value))
                    throw new ArgumentOutOfRangeException("Campo esta vazio");

                _nome = value;
            }
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [StringLength(200)]
        public string Descricao { get; set; }
        [Display(Name = "Prateleira")]
        [StringLength(10)]
        public string Prateleira { get; set; }

        private Int32 _Quantidade;
        [Display(Name = "Quantidade para Estoque")]
        public int Quantidade
        {
            get => _Quantidade;
            set
            {
                if (isQtdValida(value))
                    _Quantidade = value;
            }
        }

        private Int32 _EstoqueMinimo;
        [Display(Name = "Quantidade minima para estoque")]
        public int EstoqueMinimo
        {
            get => _EstoqueMinimo;
            set
            {
                if (isQtdValida(value))
                    _EstoqueMinimo = value;
            }
        }

        private float _valor;
        [Column(TypeName ="decimal(10,2)")]
        public float Valor
        {
            get => _valor;
            set
            {
                if (isValorValida(value))
                    _valor = value;
            }
        }

        private bool isQtdValida(int qtd)
        {
            return qtd >= 0;
        }

        private bool isValorValida(float qtd)
        {
            return qtd > 0;
        }

        private bool IsNull(String field) => field == string.Empty;
}
}
