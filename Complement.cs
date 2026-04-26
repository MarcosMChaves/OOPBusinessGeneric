using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class Complement : AText
    {
        public Complement(string text, string validPattern = SanitizationPattern.TEXT) : 
                        base(text, validPattern)
        {
        }

        public string GetComplement()
        {
            return Text;
        }
    }
}
