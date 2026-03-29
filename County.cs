using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class County : AText
    {
        private readonly State State;

        public County(string name, string validPattern, State state) : 
            base(name, validPattern)
        {
            if (name.Length < 1 ||
                name.Length > 60) // Baseado em pesquisa: maior nome tem 56 chars e o menor 1
            {
                throw new ArgumentException($"Invalid argument 'name'='{name}'! Length MUST be in the range [1, 60].");
            }

            State = state ?? throw new ArgumentNullException(nameof(state));
        }

        public string GetCounty()
        {
            return Text;
        }

    }
}
