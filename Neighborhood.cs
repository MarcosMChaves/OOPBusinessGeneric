using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class Neighborhood : AText
    {
        public Neighborhood(string text, string validPattern = SanitizationPattern.TEXT) : 
                        base(text, validPattern)
        {
        }

        public string GetNeighborhood()
        {
            return Text;
        }
    }
}
