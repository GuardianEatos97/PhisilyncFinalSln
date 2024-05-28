using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhisilyncFinal.LennyAIEnums;
namespace PhisilyncFinal.Models
{
    public class LennyAIChatMessage
    {
         
        public ChatMessageTypeEnum MessageType { get; set; }
        public string? MessageBody { get; set; }

    }


}

