using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaFarmacia.Domain.Models
{
    class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Required]
        public string nome { get; set; }
        public string  telefone { get; set; }
        
        [Required, EmailAddress]
        public string email { get; set; }
        
        [Required, MaxLength(11)]
        public int cpf { get; set; }
    }
}
