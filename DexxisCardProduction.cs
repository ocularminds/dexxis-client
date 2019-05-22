using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace dexxis.client{


    [Header("User-Agent", "RestEase")]
    public interface DexxisCardProduction {

        [Post("validateCardProductions")]
        Task<List<Dictionary<string, string>>> ValidateCardProductionsAsync([Body] Dictionary<string, object> request);

        [Post("getBranchesByUser")]
        Task<List<Dictionary<string, string>>> GetBranchesByUserAsync([Body] Dictionary<string, object> request);

        [Post("cancelCardRequests")]
        Task<List<Dictionary<string, string>>> CancelCardRequestsAsync([Body] Dictionary<string, object> request);

        [Post("getSatellitesByBranches")]
        Task<List<Dictionary<string, string>>> GetSatellitesByBranchesAsync([Body] Dictionary<string, object> request);

        [Post("getCardTypeArtworkByBranches")]
        Task<List<Dictionary<string, string>>> GetCardTypeArtworkByBranchesAsync([Body] Dictionary<string, object> request);

        [Post("getCardTypeArtworksBySatellites")]
        Task<List<Dictionary<string, string>>> GetCardTypeArtworksBySatellitesAsync([Body] Dictionary<string, object> request);

        [Post("getSatellitesStatus")]
        Task<List<Dictionary<string, string>>> GetSatellitesStatusAsync([Body] Dictionary<string, object> request);

        [Post("setPrinterLockStatus")]
        Task<Dictionary<string, string>> SetPrinterLockStatusAsync([Body] Dictionary<string, object> request);

        [Post("getCardRequestByStatusesAndBranches")]
        Task<List<Dictionary<string, string>>> GetCardRequestByStatusesAndBranchesAsync([Body] Dictionary<string, object> request);

        [Post("getCardRequestByStatusesAndSatellites")]
        Task<List<Dictionary<string, string>>> GetCardRequestByStatusesAndSatellitesAsync([Body] Dictionary<string, object> request);

        [Post("stopCardProductions")]
        Task<List<Dictionary<string, string>>> StopCardProductionsAsync([Body] Dictionary<string, object> request);

        [Post("redirectCardRequests")]
        Task<List<Dictionary<string, string>>> RedirectCardRequestsAsync([Body] Dictionary<string, object> request);

        [Post("getPrinterStatus")]
        Task<List<Dictionary<string, string>>> GetPrinterStatusAsync([Body] Dictionary<string, object> request);

        [Post("setCardProductionsOrder")]
        Task<List<Dictionary<string, string>>> SetCardProductionsOrderAsync([Body] Dictionary<string, object> request);

        [Post("getSatellitesByUser")]
        Task<List<Dictionary<string, string>>> GetSatellitesByUserAsync([Body] Dictionary<string, object> request);

        [Post("startCardProductions")]
        Task<List<Dictionary<string, string>>> StartCardProductionsAsync([Body] Dictionary<string, object> request);

        [Post("pauseSatellite")]
        Task<Dictionary<string, string>> PauseSatelliteAsync([Body] Dictionary<string, object> request);

        [Post("resumeSatellite")]
        Task<Dictionary<string, string>> ResumeSatelliteAsync(Dictionary<string, object> request);
    }
}
