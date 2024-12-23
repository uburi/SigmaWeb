using Infra.Data.Utils;
using System.ComponentModel.DataAnnotations;

namespace Application.DataTransferObjects
{
    public class PessoaDto : IValidatableObject
    {
        public int Pessoa_ID { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MaxLength(255, ErrorMessage = "O nome deve ter no máximo 255 caracteres.")]
        public string Nome_Fantasia { get; set; }

        public string CNPJ_CPF { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Nome_Fantasia))
            {
                yield return new ValidationResult("Digite um nome válido", new[] { nameof(Nome_Fantasia) });
            }

            if (string.IsNullOrWhiteSpace(CNPJ_CPF) && !Utilities.ValidateDocument(CNPJ_CPF))
            {
                yield return new ValidationResult("CPF/CNPJ é obrigatório", new[] { nameof(CNPJ_CPF) });
            }
            else if (!Utilities.ValidateDocument(CNPJ_CPF) && !Utilities.ValidateDocument(CNPJ_CPF))
            {
                yield return new ValidationResult("Digite um CPF/CNPJ válido", new[] { nameof(CNPJ_CPF) });
            }
        }
    }
}
