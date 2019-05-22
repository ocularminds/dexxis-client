using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace dexxis.client{

    public class DexxisCardIssuanceService
    {

        DexxisCardIssuance dexxisCardIssuance;

        public DexxisCardIssuanceService()
        {
            dexxisCardIssuance = RestClient.For<DexxisCardIssuance>("http://localhost:4321/api/dexxis/issuance");
        }

        public Dictionary<string, string> IsServerAvailable(Dictionary<string, object> request)
        {
            Dictionary<string, string> response = dexxisCardIssuance.IsServerAvailableAsync(request).Result;
            return response;
        }

        public Dictionary<string, string> CreateCardRequest(Dictionary<string, object> request)
        {

            Dictionary<string, string> response = dexxisCardIssuance.CreateCardRequestAsync(request).Result;
            return response;
        }

        public List<Dictionary<string, string>> CancelCardRequest(Dictionary<string, object> request)
        {

            List<Dictionary<string, string>> response = dexxisCardIssuance.CancelCardRequestAsync(request).Result;
            return response;

        }

        public List<Dictionary<string, string>> ChangeCardRequestSatellites(Dictionary<string, object> request)
        {

            List<Dictionary<string, string>> response = dexxisCardIssuance.ChangeCardRequestSatellitesAsync(request).Result;
            return response;
        }

        /**
         *
         * @param request
         * @return
         * @throws IOException
         * @throws SOAPException
         * @throws TransformerException
         * @throws ParserConfigurationException
         * @throws Exception
         */
        public List<Dictionary<string, string>> GetCardRequest(Dictionary<string, object> request)
        {

            List<Dictionary<string, string>> response = dexxisCardIssuance.GetCardRequestAsync(request).Result;
            return response;
        }

        public List<Dictionary<string, string>> GetCardRequestStatus(Dictionary<string, object> request)
        {

            List<Dictionary<string, string>> response = dexxisCardIssuance.GetCardRequestStatusAsync(request).Result;
            return response;
        }

        //@todo The getPEDsFromBranchRequest is still throwing BAD request It
        public Dictionary<string, object> GetPEDsFromBranchRequest(Dictionary<string, object> request)
        {

            Dictionary<string, object> response = dexxisCardIssuance.GetPEDsFromBranchRequestAsync(request).Result;
            return response;
        }
    }
}
