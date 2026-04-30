using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class CNPJ : AText
    {
        private const int CNPJ_LENGTH = 14;
        private const int ROOT_LENGTH = 8;
        private const int ORDER_LENGTH = 4;

        public CNPJ(string cnpj, string validPattern) : base(cnpj, validPattern)
        {
            if (!CNPJIsValid(cnpj:Text))
            {
                throw new ArgumentException($"Invalid Argument 'cnpj'='{cnpj}' Check content, length and/or DV!");
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
            if (CNPJ_LENGTH != cnpj.Length)
            {
                return false;
            }

            if (cnpj.Substring(0, ROOT_LENGTH) == new string('1', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('2', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('3', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('4', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('5', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('6', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('7', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('8', ROOT_LENGTH) ||
                cnpj.Substring(0, ROOT_LENGTH) == new string('9', ROOT_LENGTH))
            {
                return false;
            }
            if(cnpj.Substring(8, ORDER_LENGTH) == "0000"){
                return false;
            }

            if (!cnpj.Substring(12).All(char.IsDigit) ||
                cnpj.Substring(12) != CalculateCheckDigit(cnpj: cnpj))
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
