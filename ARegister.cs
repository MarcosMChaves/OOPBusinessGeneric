using OOPFoundation;

namespace OOPBusinessGeneric
{
    public abstract class ARegister : AText
    {
        private readonly int NumberLength;

        protected ARegister(string number, string validPattern, int numberLength) : base(number, validPattern)
        {
            Text = number ?? throw new ArgumentNullException(nameof(number));

            if (numberLength < 5 ||
                numberLength > 10)
            {
                throw new ArgumentException($"Invalid Argument 'numberLength'='{numberLength}' [5-10]!");
            }
            NumberLength = numberLength;

            if (Text.Length != numberLength)
            {
                throw new ArgumentException($"Invalid Argument 'number'='{number}' length={NumberLength}");
            }
        }
        private string GetNumber()
        {
            return Text;
        }

        public string ObtainFormattedRegister()
        {
            return Format();
        }

        private string Format()
        {
            return ToString("######-#", null);
        }
    }
}
