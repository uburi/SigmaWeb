using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Utils
{
    public static class Utilities
    {
        public static string ReplaceDocument(string value)
        {
            return value.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).Replace("_", string.Empty);
        }
        public static bool ValidateCPF(string valor)
        {
            var result = false;

            if (valor != null && valor != "0")
            {
                int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                bool cpfValido = true;

                string cpf = valor;

                switch (cpf)
                {
                    case "11111111111":
                        cpfValido = false;
                        break;
                    case "2222222222":
                        cpfValido = false;
                        break;
                    case "33333333333":
                        cpfValido = false;
                        break;
                    case "44444444444":
                        cpfValido = false;
                        break;
                    case "55555555555":
                        cpfValido = false;
                        break;
                    case "66666666666":
                        cpfValido = false;
                        break;
                    case "77777777777":
                        cpfValido = false;
                        break;
                    case "88888888888":
                        cpfValido = false;
                        break;
                    case "99999999999":
                        cpfValido = false;
                        break;
                }
                if (cpfValido)
                {
                    var tempCpf = cpf.Substring(0, 9);
                    var soma = 0;
                    for (int i = 0; i < 9; i++)
                        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                    var resto = soma % 11;
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    var digito = resto.ToString();

                    tempCpf = tempCpf + digito;

                    soma = 0;
                    for (int i = 0; i < 10; i++)
                        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                    resto = soma % 11;
                    if (resto < 2)
                        resto = 0;
                    else
                        resto = 11 - resto;

                    digito = digito + resto.ToString();

                    cpfValido = cpf.EndsWith(digito);
                }

                if (cpfValido)
                    result = cpfValido;
                else
                    result = false;
            }

            return result;
        }

        public static bool ValidateCNPJ(string value)
        {
            var result = false;

            if (value != null && value != "0")
            {
                string cnpj = value;
                int[] multiplier1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplier2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                bool cnpjValid = false;

                var tempCnpj = cnpj.Substring(0, 12);

                var soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplier1[i];

                var resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                var digito = resto.ToString();

                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplier2[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto;

                cnpjValid = cnpj.EndsWith(digito);


                result = cnpjValid;
            }

            return result;
        }

        public static bool ValidateDocument(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            var doc = ReplaceDocument(value);

            if (doc.Length == 11)
                return ValidateCPF(doc);

            else if (doc.Length == 14)
                return ValidateCNPJ(doc);

            return false;
        }
    }
}
