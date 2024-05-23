using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.LennyConfiguration
{
    public class AiSettings:ISettings
     {
        public string AzureSearchEndPoint { get => "https://lennyaisearch.search.windows.net"; }
        public string AzureSearchKey { get => "w3FmVlpd8fsiV7uVgjRDaE68aydTsBYOu1Zvz1zv06AzSeCKEM5M"; }
        public string AzureOpenAiEndPoint { get => "https://ketchatgpt4.openai.azure.com/"; }
        public string AzureOpenAiKey { get => "f3057d4eb2fc4bc0b1bfc143c5b43009"; }
    }
}
