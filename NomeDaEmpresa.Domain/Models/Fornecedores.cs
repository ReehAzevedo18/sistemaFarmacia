using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaFarmacia.Domain.Models
{
    class Fornecedores
    {
        [Key]
        public int idFornecedor { get; set; }

        [Required]
        public string nome { get; set; }

        public int telefone { get; set; }

        [Required]
        public int CNPJ { get; set; }
    }
}
