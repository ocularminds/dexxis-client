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

        public bool IsServerAvailable(Dictionary<string, object> request)
        {
            Boolean response = dexxisCardIssuance.IsServerAvailableAsync(request).Result;
            return response;
        }

        public int CreateCardRequest(Dictionary<string, object> request)
        {

            Int32 response = dexxisCardIssuance.CreateCardRequestAsync(request).Result;
            return response;
        }

        public List<int> CancelCardRequest(Dictionary<string, object> request)
        {

            List<int> response = dexxisCardIssuance.CancelCardRequestAsync(request).Result;
            return response;

        }

        public List<int> ChangeCardRequestSatellites(Dictionary<string, object> request)
        {

            List<int> response = dexxisCardIssuance.ChangeCardRequestSatellitesAsync(request).Result;
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
        public List<String> GetCardRequest(Dictionary<string, object> request)
        {

            List<String> response = dexxisCardIssuance.GetCardRequestAsync(request).Result;
            return response;
        }

        public List<String> GetCardRequestStatus(Dictionary<string, object> request)
        {

            List<String> response = dexxisCardIssuance.GetCardRequestStatusAsync(request).Result;
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
