
namespace UtilityBox
{
    public static class CommonRegexPatterns
    {
        public const string Email = @"^(?![.-])([a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+\.[a-zA-Z]{2,})$";
        public const string PhoneNumber = @"^(\+?\d{1,2})?[\s\-]?\(?\d{1,4}[\s\)\-]?\d{1,4}[\s\-]?\d{1,4}$";
        public const string SSN = @"^(?!000|666|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$";
        public const string CreditCard = @"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9]{2})[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|7[0-9]{15})$";
        public const string CreditCardExpirationDate = @"^(0[1-9]|1[0-2])\/\d{2}$";
        

    }
}
