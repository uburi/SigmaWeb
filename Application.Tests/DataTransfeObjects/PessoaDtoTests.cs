using Application.DataTransferObjects;
using System.ComponentModel.DataAnnotations;
using Xunit;
namespace Application.Tests.DataTransfeObjects
{

    public class PessoaDtoTests
    {
        [Fact]
        public void Validate_ShouldReturnError_WhenNomeFantasiaIsEmpty()
        {
            var dto = new PessoaDto
            {
                Nome_Fantasia = "",
                CNPJ_CPF = "12345678901"
            };
            var validationContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(dto, validationContext, validationResults, true);

            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "O nome é obrigatório.");
        }

        [Fact]
        public void Validate_ShouldReturnError_WhenCNPJCPFIsEmpty()
        {
            var dto = new PessoaDto
            {
                Nome_Fantasia = "Nome Válido",
                CNPJ_CPF = ""
            };
            var validationContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(dto, validationContext, validationResults, true);

            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "CPF/CNPJ É Obrigatório");
        }

    }
}