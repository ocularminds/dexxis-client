using System;
using System.Collections.Generic;
using System.Text;

namespace dexxis.client
{
    public class WebServiceResponse{
        public string error { get; set; }
        public string description { get; set; }
        public object data { get; set; }
    }
}
