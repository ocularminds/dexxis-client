using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace dexxis.client { 

    public class DexxisCardProductionService {

        DexxisCardProduction dexxisCardProduction;

        public DexxisCardProductionService()
        {
            dexxisCardProduction = RestClient.For<DexxisCardProduction>("http://localhost:4321/api/dexxis/i2-production");
        }

        public List<Dictionary<string, string>> ValidateCardProductions(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.ValidateCardProductionsAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetBranchesByUser(Dictionary<string, object> request){
            List<Dictionary<string, string>> response = dexxisCardProduction.GetBranchesByUserAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> CancelCardRequests(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.CancelCardRequestsAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetSatellitesByBranches(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetSatellitesByBranchesAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetCardTypeArtworkByBranches(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetCardTypeArtworkByBranchesAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetCardTypeArtworksBySatellites(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetCardTypeArtworksBySatellitesAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetSatellitesStatus(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetSatellitesStatusAsync(request).Result;
            return response;
        }


        public Dictionary<string, string> SetPrinterLockStatus(Dictionary<string, object> request) {
            Dictionary<string, string> response = dexxisCardProduction.SetPrinterLockStatusAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetCardRequestByStatusesAndBranches(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetCardRequestByStatusesAndBranchesAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetCardRequestByStatusesAndSatellites(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetCardRequestByStatusesAndSatellitesAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> StopCardProductions(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.StopCardProductionsAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> RedirectCardRequests(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.RedirectCardRequestsAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetPrinterStatus(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetPrinterStatusAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> SetCardProductionsOrder(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.SetCardProductionsOrderAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> GetSatellitesByUser(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.GetSatellitesByUserAsync(request).Result;
            return response;
        }


        public List<Dictionary<string, string>> StartCardProductions(Dictionary<string, object> request)
        {
            List<Dictionary<string, string>> response = dexxisCardProduction.StartCardProductionsAsync(request).Result;
            return response;
        }


        public Dictionary<string, string> PauseSatellite(Dictionary<string, object> request) {
            Dictionary<string, string> response = dexxisCardProduction.PauseSatelliteAsync(request).Result;
            return response;
	}


        public Dictionary<string, string> ResumeSatellite(Dictionary<string, object> request)
        {
            Dictionary<string, string> response = dexxisCardProduction.ResumeSatelliteAsync(request).Result;
            return response;
        }
	}
}
