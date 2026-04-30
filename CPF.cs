using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class CPF : AText
    {
        private const int CPF_LENGTH = 11;
        private const int ROOT_LENGTH = 9;

        public CPF(string cpf, string validPattern) : base(cpf, validPattern)
        {
            if (!CPFIsValid(cpf:Text))
            {
                throw new ArgumentException($"Invalid Argument 'cpf'='{cpf}' Check content, length and/or DV!");
            }
        }

        public string GetCPF()
        {
            return Text;
        }

        public string ObtainFormattedCPF()
        {
            return Format();
        }

        private bool CPFIsValid(string cpf)
        {
            if (CPF_LENGTH != cpf.Length)
            {
                return false;
            }

            if (cpf.Substring(0, ROOT_LENGTH) == new string('0', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('1', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('2', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('3', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('4', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('5', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('6', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('7', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('8', ROOT_LENGTH) ||
                cpf.Substring(0, ROOT_LENGTH) == new string('9', ROOT_LENGTH))
            {
                return false;
            }

            if(cpf.Substring(9) != CalculateCheckDigit(cpf: cpf))
            {
                return false;
            }

            return true;
        }
        public string CalculateCheckDigit(string cpf)
        {
            // Implementa o cálculo do Dígito Verificador do CPF (Google Gemini, 2026)
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, ROOT_LENGTH);
            int soma = 0;

            for (int i = 0; i < ROOT_LENGTH; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < ROOT_LENGTH + 1; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito = digito + resto.ToString();

            return digito;
        }

        public string Format()
        {
            return ToString("###.###.###-##");

        }

        public string ObtainHashedCPF()
        {
            return ObtainHashedText();
        }
    }
}
