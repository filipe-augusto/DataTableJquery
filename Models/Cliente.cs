using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataTableJquery.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public int ID { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome do cliente é obrigatório", AllowEmptyStrings = false)]
        public string ClienteNome { get; set; }
        [Display(Name = "Email")]
        public string ClienteEmail { get; set; }
        [Display(Name = "Telefone")]
        public string ClienteFone { get; set; }
        [Display(Name = "Estado")]
        public string ClienteEstado { get; set; }
        public string ClienteImagem { get; set; }
    }
}