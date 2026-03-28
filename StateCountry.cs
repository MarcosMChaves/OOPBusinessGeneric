
namespace OOPBusinessGeneric
{
    public class StateCountry
    {
        private readonly State State;
        private readonly Country Country;

        public StateCountry(State state, Country country)
        {
            State = state ?? throw new ArgumentNullException(nameof(state));
            Country = country ?? throw new ArgumentNullException(nameof(country));
        }

        public string GetState()
        {
            return State.GetState();
        }

        public string GetCountry()
        {
            return Country.GetCountry();
        }
    }
}
