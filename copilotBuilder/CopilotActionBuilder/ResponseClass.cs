using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopilotBuilder.CopilotActionBuilder
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ResponseClass
    {
        public string parameterName { get; set; }
        public string parameterPurpose { get; set; }
    }

    public class ResponseBlock
    {
        public string classDescription { get; set; }
        public List<ResponseClass> parameters { get; set; }
    }
}
