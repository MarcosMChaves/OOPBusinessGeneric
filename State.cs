using OOPFoundation;
using System.Security.Cryptography.X509Certificates;

namespace OOPBusinessGeneric
{
    public class State : AText
    {
        private readonly Acronym ISOStateCode; //ISO 3166-2
        private readonly Country Country;

        public State(string name, string validPattern, Acronym isoStateCode, Country country) : 
            base(name, validPattern)
        {
            if (name.Length < 1 ||
                name.Length > 60) // Baseado em pesquisa: maior nome tem 56 chars e o menor 1
            {
                throw new ArgumentException($"Invalid argument 'name'='{name}'! Length MUST be in the range [1, 60].");
            }

            ISOStateCode = isoStateCode ?? throw new ArgumentNullException(nameof(isoStateCode));
            Country = country ?? throw new ArgumentNullException(nameof(country));
        }

        public string GetState()
        {
            return Text;
        }
        public string GetAcronym()
        {
            return ISOStateCode.GetAcronym();
        }
        public string ObtainCountryStateAcronym()
        {
            return $"{Country.GetCountry().ToUpper()} {GetAcronym()}";
        }
        public string ObtainCountryOnly()
        {
            return $"{Country.GetCountry().ToUpper()}";
        }
    }
}
