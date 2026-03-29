using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class PaymentData
    {
        private readonly Currency Value;
        private bool Status = false;

        public PaymentData(Currency value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public void SetStatus(bool status) 
        { 
            Status = status;
        }

        public string ObtainPaymentData()
        {
            return $"{Value.ObtainFormattedCurrency()} Status: {Status}";
        }
    }
}
