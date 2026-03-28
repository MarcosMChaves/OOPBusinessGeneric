using OOPFoundation;

namespace OOPBusinessGeneric
{
    public abstract class APaymentMethod : AText
    {
        private readonly Acronym Acronym;
        protected readonly PaymentData Payment;

        protected APaymentMethod(string text, string validPattern, Acronym acronym, PaymentData payment) : 
            base(text, validPattern)
        {
            Acronym = acronym ?? throw new ArgumentNullException(nameof(acronym));
            Payment = payment ?? throw new ArgumentNullException(nameof(payment));
        }

        public abstract PaymentData ProcessPayment();
    }
}
