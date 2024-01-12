using System;
using System.Collections.Generic;

namespace example_csharp_api_tef.entities
{
    public class InitRequest
    {

        public InitRequest(bool contactless, string applicationName, string applicationVersion, string activationCode, PinpadMessages pinpadMessages){
            this.activationCode = activationCode;
            this.applicationName = applicationName;
            this.applicationVersion = applicationVersion;
            this.contactless = contactless;
            this.pinpadMessages = pinpadMessages;
        }

        public bool contactless { get; set; }
        public List<String> pinpadPortNames { get; set; }
        public List<String> pinpadBluetoothAddresses { get; set; }
        public PinpadMessages pinpadMessages { get; set; }
        public string activationCode { get; set; }
        public string applicationVersion { get; set; }
        public string applicationName { get; set; }

    }
}