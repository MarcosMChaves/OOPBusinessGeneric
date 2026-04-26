using OOPFoundation;

namespace OOPBusinessGeneric
{
    public abstract class APerson
    {
        private readonly Text FirstName;
        private readonly Text LastName;
        private readonly Text MiddleNames;
        private readonly Year BirthYear;
        private Address? Address;

        public APerson(Text firstName, Text lastName, Text middleNames, Year birthYear, Address address=null)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            MiddleNames = middleNames ?? throw new ArgumentNullException(nameof(middleNames));
            BirthYear = birthYear ?? throw new ArgumentNullException(nameof(birthYear));
            Address = address;
        }

        public string ObtainFullName()
        {
            return $"{FirstName.GetText()} {MiddleNames.GetText()} {LastName.GetText()}";
        }
        public string ObtainFirstLastNames()
        {
            return $"{FirstName.GetText()} {LastName.GetText()}";
        }
        public void SetAddress(Address address)
        {
            Address = address;
        }
        public string ObtainFormattedAddress()
        {
            if(Address == null)
            {
                return "N/A";
            }

            return Address.ObtainAddress();
        }

        public int AgeInYearsOnly => DateTime.Now.Year - BirthYear.GetYear();
    }
}
