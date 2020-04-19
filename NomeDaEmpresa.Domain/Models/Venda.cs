using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaFarmacia.Domain.Models
{
    class Venda
    {
        [Key]
        public int idVenda { get; set; }

        //[ForeignKey]
        public int venda_idCliente { get; set; }
        //[ForeignKey]
        public int medicamento_idMedicamento { get; set; }
                
        public DateTime dtVenda { get; set; }
    }
}
