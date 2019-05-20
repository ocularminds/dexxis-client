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
        Task<Boolean> IsServerAvailableAsync([Body] Dictionary<String, object> request);

        [Post("createCardRequest")]
        Task<Int32> CreateCardRequestAsync([Body] Dictionary<String, object> request);

        [Post("CancelCardRequest")]
        Task<List<Int32>> CancelCardRequestAsync([Body] Dictionary<String, object> request);

        [Post("changeCardRequestSatellites")]
        Task<List<Int32>> ChangeCardRequestSatellitesAsync([Body] Dictionary<String, object> request);

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
        Task<List<String>> GetCardRequestAsync([Body] Dictionary<String, object> request);

        [Post("getCardRequestStatus")]
        Task<List<String>> GetCardRequestStatusAsync([Body] Dictionary<String, object> request);

        [Post("getPEDsFromBranchRequest")]
        Task<Dictionary<string, object>> GetPEDsFromBranchRequestAsync([Body] Dictionary<String, object> request);
    }
}
