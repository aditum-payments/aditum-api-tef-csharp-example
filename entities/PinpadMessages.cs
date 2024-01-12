using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example_csharp_api_tef.entities
{
    public class PinpadMessages
    {
        private string approvedMessage { get; set; }
        private string declinedMessage { get; set; }
        private string initializationMessage { get; set; }
        private string mainMessage { get; set; }
        private string processingMessage { get; set; }

        public PinpadMessages() { }

        public PinpadMessages(string approvedMessage, string declinedMessage, string initializationMessage,  string processingMessage)
        {
            this.approvedMessage = approvedMessage;
            this.declinedMessage = declinedMessage;
            this.initializationMessage = initializationMessage;
            this.processingMessage = processingMessage;
        }
    }
}
