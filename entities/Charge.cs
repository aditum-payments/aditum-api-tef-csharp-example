namespace example_csharp_api_tef.entities
{
    public class Charge
    {
        public Charge(int amount,
                      string paymentType,
                      string installmentType)
        {
            this.amount = amount;
            this.paymentType = paymentType;
            this.installmentType = installmentType;
        }
        public int amount { get; set; }
        public string paymentType { get; set; }
        public string installmentType { get; set; }
        public int installmentNumber { get; set; }
        public string creationDateTime { get; set; }
        public string transactionIdOnAcquirer {get; set;}
        public bool isCanceled {get; set;}
        public string transactionId {get; set;}
        public string cardBrand {get; set;}
        public string acquirerName {get; set;}
        public string aid {get; set;}
        public string cardholderName {get; set;}
        public string authorizationCode {get; set;}
        public string cardNumber {get; set;}
        public bool approved {get; set;}

    }
}