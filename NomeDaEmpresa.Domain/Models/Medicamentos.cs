using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaFarmacia.Domain.Models
{
    class Medicamentos
    {
        [Key]
        public int idMedicamento { get; set; }
        [Required]
        public string nome { get; set; }

        public string descricao { get; set; }

        public string indicacao { get; set; }
        [Required]
        public float valor { get; set; }
        //[ForeignKey]
        public int medicamento_idFornecedor { get; set; }
    }
}
