using OOPFoundation;

namespace OOPBusinessGeneric
{
    public abstract class APerson
    {
        private readonly Text FirstName;
        private readonly Text LastName;
        private readonly Text MiddleNames;
        // TODO Create Address; but first MUST create Address and other necessary classes

        public APerson(Text firstName, Text lastName, Text middleNames)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            MiddleNames = middleNames ?? throw new ArgumentNullException(nameof(middleNames));
        }

        public string ObtainFullName()
        {
            return $"{FirstName.GetText()} {MiddleNames.GetText()} {LastName.GetText()}";
        }
        public string ObtainFirstLastNames()
        {
            return $"{FirstName.GetText()} {LastName.GetText()}";
        }
        // TODO Create SetAddress

        // TODO Create ObtainFormattedAddress

    }
}
