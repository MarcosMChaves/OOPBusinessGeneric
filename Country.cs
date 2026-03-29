using OOPFoundation;
namespace OOPBusinessGeneric
{
    public class Country : AText
    {
        private readonly Acronym ISOCountryCode; //ISO 3166-1

        public Country(string name, string validPattern, Acronym isoCountryCode) : 
            base(name, validPattern)
        {
            if (name.Length < 3 || 
                name.Length > 60) // Baseado em pesquisa: maior nome tem 56 chars e o menor 3
            {
                throw new ArgumentException($"Invalid argument 'name'='{name}'! Length MUST be in the range [3, 60].");
            }
            ISOCountryCode = isoCountryCode ?? throw new ArgumentNullException(nameof(isoCountryCode));
        }

        public string GetCountry()
        {
            return Text;
        }

        public string GetAcronym()
        {
            return ISOCountryCode.GetAcronym();
        }
    }
}
