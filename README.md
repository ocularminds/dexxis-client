# dexxis-client
C# implementation of restful services client using RestEase framework

Usage:

```java
            Console.WriteLine("Welcome to Dexxis Client 1.0");
            DexxisCardIssuanceService issuanceService = new DexxisCardIssuanceService();

            var request = new Dictionary<string, object>(){
                { "login",  "pajunoapp"},
                { "password", "CkERPQTlFynkRXsCZIUBrdxcPFCLfeYqv/8INd9F1+M="}
            };
            Dictionary<string, string> response = issuanceService.IsServerAvailable(request);
            Console.WriteLine("server response -> " + response);
            
            DexxisCardProductionService production = new DexxisCardProductionService();
            response = production.ValidateCardProductions(request);
            Console.WriteLine("server response -> " + response);
```
