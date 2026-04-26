using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class PublicWay : AText
    {
        public PublicWay(string text, string validPattern = SanitizationPattern.TEXT) : 
                        base(text, validPattern)
        {
        }

        public string GetPublicWay()
        {
            return Text;
        }
    }
}
