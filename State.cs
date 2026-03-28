using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class State : AText
    {
        private readonly Acronym ISOStateCode; //ISO 3166-2
        private readonly Country Country;

        public State(string name, string validPattern, Acronym isoStateCode, Country country) : 
            base(name, validPattern)
        {
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

    }
}
