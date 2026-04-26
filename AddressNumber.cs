using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class AddressNumber : AText
    {
        public AddressNumber(string text="S/N", string validPattern = SanitizationPattern.DIGITS_ONLY + "^S/N$") : 
                        base(text, validPattern)
        {
        }

        public string GetAddressNumber()
        {
            return Text;
        }
    }
}
