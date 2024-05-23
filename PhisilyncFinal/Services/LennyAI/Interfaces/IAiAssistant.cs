using Azure.AI.OpenAI;
using PhisilyncFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Services.LennyAI.Interfaces
{
    public interface IAiAssistant
    {
        ChatResponseMessage GetCompletion(IList<LennyAIChatMessage> chatInboundHistory, LennyAIChatMessage userMessage);

    }
}
