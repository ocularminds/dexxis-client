using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace dexxis.client
{

    [Header("User-Agent", "RestEase")]
    public interface DexxisCardIssuance
    {

        [Post("isServerAvailable")]
        Task<Dictionary<string, string>> IsServerAvailableAsync([Body] Dictionary<String, object> request);

        [Post("createCardRequest")]
        Task<Dictionary<string, string>> CreateCardRequestAsync([Body] Dictionary<String, object> request);

        [Post("CancelCardRequest")]
        Task<List<Dictionary<string, string>>> CancelCardRequestAsync([Body] Dictionary<String, object> request);

        [Post("changeCardRequestSatellites")]
        Task<List<Dictionary<string, string>>> ChangeCardRequestSatellitesAsync([Body] Dictionary<String, object> request);

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
        [Post("getCardRequest")]
        Task<List<Dictionary<string, string>>> GetCardRequestAsync([Body] Dictionary<String, object> request);

        [Post("getCardRequestStatus")]
        Task<List<Dictionary<string, string>>> GetCardRequestStatusAsync([Body] Dictionary<String, object> request);

        [Post("getPEDsFromBranchRequest")]
        Task<Dictionary<string, object>> GetPEDsFromBranchRequestAsync([Body] Dictionary<String, object> request);
    }
}
