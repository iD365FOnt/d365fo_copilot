using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopilotBuilder.CopilotActionBuilder
{
    internal class RequestClass
    {
        public string parameterName { get; set; }

        public class Root
        {
            public string classDescription { get; set; }
            public List<RequestClass> parameters { get; set; }
        }

    }
}
