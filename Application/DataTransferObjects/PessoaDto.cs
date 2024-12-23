using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObjects
{
    public class PessoaDto
    {
        public int Pessoa_ID { get; set; }
        public string Nome_Fantasia { get; set; }
        public string CNPJ_CPF { get; set; }
    }
}
