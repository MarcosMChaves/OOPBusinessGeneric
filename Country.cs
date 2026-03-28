using OOPFoundation;
namespace OOPBusinessGeneric
{
    public class Country : AText
    {
        private readonly Acronym ISOCountryCode; //ISO 3166-1

        public Country(string name, string validPattern, Acronym isoCountryCode) : 
            base(name, validPattern)
        {
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
