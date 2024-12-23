using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pessoa 
    {
        [Key]
        public int Pessoa_ID { get; set; }
        public string Nome_Fantasia { get; set; }
        public string CNPJ_CPF { get; set; }
    }
}
