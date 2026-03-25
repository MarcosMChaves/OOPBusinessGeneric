using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class CPF
    {
        private readonly Text Number;

        public CPF(Text number)
        {
            if (!CPFIsValid(cpf:number.GetText()))
            {
                throw new ArgumentException($"Invalid Argument 'number'='{number.GetText()}'!");
            }
            Number = number;
        }

        public string GetCPF()
        {
            return Number.GetText();
        }

        public string ObtainFormattedCPF()
        {
            return Format();
        }

        private bool CPFIsValid(string cpf)
        {
            const int REPETITION = 9;
            if (cpf.Length != 11 ||
                cpf.Substring(0, REPETITION) == new string('0', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('1', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('2', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('3', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('4', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('5', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('6', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('7', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('8', REPETITION) ||
                cpf.Substring(0, REPETITION) == new string('9', REPETITION) ||
                cpf.Substring(9) != CalculateCheckDigit(cpf:cpf))
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

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito = digito + resto.ToString();

            return digito;
        }

        public string Format()
        {
            return string.Format("{0:000\\.000\\.000-00}", long.Parse(GetCPF()));
        }

        public string ObtainHashedCPF()
        {
            return Number.ObtainHashedText();
        }
    }
}
