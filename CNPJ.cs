using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class CNPJ : AText
    {
        public CNPJ(string cnpj, string validPattern) : base(cnpj, validPattern)
        {
            if (!CNPJIsValid(cnpj:Text))
            {
                throw new ArgumentException($"Invalid Argument 'cnpj'='{cnpj}'!");
            }
        }

        public string GetCNPJ()
        {
            return Text;
        }

        public string ObtainFormattedCNPJ()
        {
            return Format();
        }

        private bool CNPJIsValid(string cnpj)
        {
            int REPETITION = 8;
            if (cnpj.Length != 14 ||
                cnpj.Substring(0, REPETITION) == new string('1', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('2', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('3', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('4', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('5', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('6', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('7', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('8', REPETITION) ||
                cnpj.Substring(0, REPETITION) == new string('9', REPETITION) ||
                cnpj.Substring(8, 4) == "0000" ||
                cnpj.Substring(12) != CalculateCheckDigit(cnpj:cnpj))
            {
                return false;
            }

            return true;
        }
        public string CalculateCheckDigit(string cnpj)
        {
            // Implementa o cálculo do Dígito Verificador do CNPJ (adaptado de Google Gemini, 2026)
            int[] pesos = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cnpj12 = cnpj.Substring(0, 12); // Raiz+Ordem

            int soma = 0;
            for (int i = 0; i < cnpj12.Length; i++)
            {
                soma += ConvertToInteger(cnpj12[i]) * pesos[i + 1];
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            string cnpj13 = cnpj.Substring(0, 12) + $"{digito1,1}"; // Raiz+Ordem+1ºDV (calculado)

            soma = 0;
            for (int i = 0; i < cnpj13.Length; i++)
            {
                soma += ConvertToInteger(cnpj13[i]) * pesos[i];
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return $"{digito1,1}{digito2,1}";
        }

        private int ConvertToInteger(char caractere)
        {
            return caractere - 48;
        }

        public string Format()
        {
            return ToString("##.###.###/####-##");
        }

        public string ObtainHashedCNPJ()
        {
            return ObtainHashedText();
        }

    }
}
