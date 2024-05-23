using PhisilyncFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhisilyncFinal.Views.LennyTemplates
{
    public class ChatMessageTemplateSelector:DataTemplateSelector
    {
        public DataTemplate? InboundTemplate { get; set; }
        public DataTemplate? OutboundTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((LennyAIChatMessage)item).MessageType == LennyAIEnums.ChatMessageEnums.Inbound ? InboundTemplate : OutboundTemplate;
        }


    }
}
