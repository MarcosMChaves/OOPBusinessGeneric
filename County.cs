using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class County : AText
    {
        private readonly State State;

        public County(string name, string validPattern, State state) : 
            base(name, validPattern)
        {
            State = state ?? throw new ArgumentNullException(nameof(state));
        }
    }
}
