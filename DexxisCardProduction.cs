using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace dexxis.client{


    [Header("User-Agent", "RestEase")]
    public interface DexxisCardProduction {

        [Post("validateCardProductions")]
        Task<List<int>> ValidateCardProductionsAsync([Body] Dictionary<string, object> request);

        [Post("getBranchesByUser")]
        Task<List<String>> GetBranchesByUserAsync([Body] Dictionary<string, object> request);

        [Post("cancelCardRequests")]
        Task<List<int>> CancelCardRequestsAsync([Body] Dictionary<string, object> request);

        [Post("getSatellitesByBranches")]
        Task<List<String>> GetSatellitesByBranchesAsync([Body] Dictionary<string, object> request);

        [Post("getCardTypeArtworkByBranches")]
        Task<List<String>> GetCardTypeArtworkByBranchesAsync([Body] Dictionary<string, object> request);

        [Post("getCardTypeArtworksBySatellites")]
        Task<List<String>> GetCardTypeArtworksBySatellitesAsync([Body] Dictionary<string, object> request);

        [Post("getSatellitesStatus")]
        Task<List<String>> GetSatellitesStatusAsync([Body] Dictionary<string, object> request);

        [Post("setPrinterLockStatus")]
        Task<int> SetPrinterLockStatusAsync([Body] Dictionary<string, object> request);

        [Post("getCardRequestByStatusesAndBranches")]
        Task<List<String>> GetCardRequestByStatusesAndBranchesAsync([Body] Dictionary<string, object> request);

        [Post("getCardRequestByStatusesAndSatellites")]
        Task<List<String>> GetCardRequestByStatusesAndSatellitesAsync([Body] Dictionary<string, object> request);

        [Post("stopCardProductions")]
        Task<List<int>> StopCardProductionsAsync([Body] Dictionary<string, object> request);

        [Post("redirectCardRequests")]
        Task<List<int>> RedirectCardRequestsAsync([Body] Dictionary<string, object> request);

        [Post("getPrinterStatus")]
        Task<List<String>> GetPrinterStatusAsync([Body] Dictionary<string, object> request);

        [Post("setCardProductionsOrder")]
        Task<List<int>> SetCardProductionsOrderAsync([Body] Dictionary<string, object> request);

        [Post("getSatellitesByUser")]
        Task<List<String>> GetSatellitesByUserAsync([Body] Dictionary<string, object> request);

        [Post("startCardProductions")]
        Task<List<int>> StartCardProductionsAsync([Body] Dictionary<string, object> request);

        [Post("pauseSatellite")]
        Task<int> PauseSatelliteAsync([Body] Dictionary<string, object> request);

        [Post("resumeSatellite")]
        Task<int> ResumeSatelliteAsync(Dictionary<string, object> request);
    }
}
