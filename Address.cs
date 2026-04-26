
namespace OOPBusinessGeneric
{
    public class Address
    {
        private readonly PublicWay PublicWay;
        private readonly AddressNumber Number;
        private readonly Complement? Complement;
        private readonly Neighborhood Neighborhood;
        private readonly County County;
        private readonly ZIPCode ZIPCode;

        public Address(PublicWay publicWay, 
                        AddressNumber number, 
                        Neighborhood neighborhood, 
                        County county, 
                        ZIPCode zipCode,
                        Complement complement=null)
        {
            PublicWay = publicWay ?? throw new ArgumentNullException(nameof(publicWay));
            Number = number ?? throw new ArgumentNullException(nameof(number));
            Complement = complement;
            Neighborhood = neighborhood ?? throw new ArgumentNullException(nameof(neighborhood));
            County = county ?? throw new ArgumentNullException(nameof(county));
            ZIPCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        }

        public string ObtainAddress()
        {
            // Padrão Correios
            // https://www.correios.com.br/enviar/precisa-de-ajuda/guia-de-enderecamento/guia-de-enderecamento

            string complemento = string.Empty;
            if (Complement != null)
            {
                complemento = $"{Complement.GetComplement()}/";
            }

            return $"{PublicWay.GetPublicWay()}, {Number.GetAddressNumber()} " +
                    $"\n{complemento}" +
                    $"{Neighborhood.GetNeighborhood()}" +
                    $"\n{ZIPCode.ObtainFormattedZIPCode()} {County.ObtainCountyStateAcronym()}";
        }
    }
}
