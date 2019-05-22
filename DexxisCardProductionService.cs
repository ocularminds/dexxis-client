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

        public List<int> ValidateCardProductions(Dictionary<string, object> request)
        {
            List<int> response = dexxisCardProduction.ValidateCardProductionsAsync(request).Result;
            return response;
        }


        public List<String> GetBranchesByUser(Dictionary<string, object> request){
            List<String> response = dexxisCardProduction.GetBranchesByUserAsync(request).Result;
            return response;
        }


        public List<int> CancelCardRequests(Dictionary<string, object> request)
        {
            List<int> response = dexxisCardProduction.CancelCardRequestsAsync(request).Result;
            return response;
        }


        public List<String> GetSatellitesByBranches(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetSatellitesByBranchesAsync(request).Result;
            return response;
        }


        public List<String> GetCardTypeArtworkByBranches(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetCardTypeArtworkByBranchesAsync(request).Result;
            return response;
        }


        public List<String> GetCardTypeArtworksBySatellites(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetCardTypeArtworksBySatellitesAsync(request).Result;
            return response;
        }


        public List<String> GetSatellitesStatus(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetSatellitesStatusAsync(request).Result;
            return response;
        }


        public int SetPrinterLockStatus(Dictionary<string, object> request) {
            int response = dexxisCardProduction.SetPrinterLockStatusAsync(request).Result;
            return response;
        }


        public List<String> GetCardRequestByStatusesAndBranches(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetCardRequestByStatusesAndBranchesAsync(request).Result;
            return response;
        }


        public List<String> GetCardRequestByStatusesAndSatellites(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetCardRequestByStatusesAndSatellitesAsync(request).Result;
            return response;
        }


        public List<int> StopCardProductions(Dictionary<string, object> request)
        {
            List<int> response = dexxisCardProduction.StopCardProductionsAsync(request).Result;
            return response;
        }


        public List<int> RedirectCardRequests(Dictionary<string, object> request)
        {
            List<int> response = dexxisCardProduction.RedirectCardRequestsAsync(request).Result;
            return response;
        }


        public List<String> GetPrinterStatus(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetPrinterStatusAsync(request).Result;
            return response;
        }


        public List<int> SetCardProductionsOrder(Dictionary<string, object> request)
        {
            List<int> response = dexxisCardProduction.SetCardProductionsOrderAsync(request).Result;
            return response;
        }


        public List<String> GetSatellitesByUser(Dictionary<string, object> request)
        {
            List<String> response = dexxisCardProduction.GetSatellitesByUserAsync(request).Result;
            return response;
        }


        public List<int> StartCardProductions(Dictionary<string, object> request)
        {
            List<int> response = dexxisCardProduction.StartCardProductionsAsync(request).Result;
            return response;
        }


        public int PauseSatellite(Dictionary<string, object> request) { 
             int response = dexxisCardProduction.PauseSatelliteAsync(request).Result;
            return response;
	}


        public int ResumeSatellite(Dictionary<string, object> request)
        {
            int response = dexxisCardProduction.ResumeSatelliteAsync(request).Result;
            return response;
        }
	}
}
