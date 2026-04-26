using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class ZIPCode : AText
    {
        private int ZIPLength = 8;

        public ZIPCode(string text, int length = 8, string validPattern = SanitizationPattern.DIGITS_ONLY) : 
                        base(text, validPattern)
        {
            ZIPLength = length;

            if(Text.Length != ZIPLength)
            {
                throw new ArgumentException($"Invalid Argument 'text'='{text}' length MUST be {ZIPLength}");
            }
        }

        public string GetZIPCode()
        {
            return Text;
        }
        public string ObtainFormattedZIPCode()
        {
            return ToString("#####-###");
        }
    }
}
