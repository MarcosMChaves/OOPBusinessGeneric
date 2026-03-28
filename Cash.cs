using OOPFoundation;

namespace OOPBusinessGeneric
{
    public class Cash : APaymentMethod
    {
        public Cash(string text, string validPattern, Acronym acronym, PaymentData payment) : 
            base(text, validPattern, acronym, payment)
        {
        }
        public override PaymentData ProcessPayment()
        {
            Payment.SetStatus(true);
            return Payment;
        }
    }
}
