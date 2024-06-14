using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhisilyncFinal.LennyConfiguration;
using PhisilyncFinal.Models;
using Azure;
using PhisilyncFinal.Services.LennyAI.Interfaces;
using Azure.AI.OpenAI;

namespace PhisilyncFinal.Services.LennyAI
{
    public class LennyAiAssistant:IAiAssistant
    {
        private ISettings _settings;
        private const string AssistantBehaviorDescription = "Your name is Lenny! Your main goal is to give good medical advice to the patience to be a good friendly bot that will help them with everything else.You will give information not only based on the information your are trained on, but also information from the internet";

        public LennyAiAssistant(ISettings settings)
        {
            _settings = settings;
        }

        private IList<ChatRequestMessage> BuildChatContext(IList<LennyAIChatMessage> chatInboundHistory, LennyAIChatMessage userMessage)
        {
            var chatContext = new List<ChatRequestMessage>();

            chatContext.Add(new ChatRequestSystemMessage(AssistantBehaviorDescription));

            foreach (var chatMessage in chatInboundHistory)
                chatContext.Add(new ChatRequestAssistantMessage(chatMessage.MessageBody));

            chatContext.Add(new ChatRequestUserMessage(userMessage.MessageBody));

            return chatContext;

        }   

        public ChatResponseMessage GetCompletion(IList<LennyAIChatMessage> chatInboundHistory, LennyAIChatMessage userMessage)
        {
            var messages = BuildChatContext(chatInboundHistory, userMessage);

            var client = new OpenAIClient(new Uri(_settings.AzureOpenAiEndPoint), new AzureKeyCredential(_settings.AzureOpenAiKey));
            string deploymentName = "ketchatgpt4";
            string searchIndex = "lennyaiindex";

            var chatCompletionsOptions = new ChatCompletionsOptions()
            {
                AzureExtensionsOptions = new AzureChatExtensionsOptions()
                {
                    Extensions =
        {
            new AzureSearchChatExtensionConfiguration()
            {
                SearchEndpoint = new Uri(_settings.AzureSearchEndPoint),
                Authentication = new OnYourDataApiKeyAuthenticationOptions(_settings.AzureSearchKey),

                IndexName = searchIndex,
            },
                    }
                },
                DeploymentName = deploymentName
            };

            foreach (var message in messages)
                chatCompletionsOptions.Messages.Add(message);

            Response<ChatCompletions> response = client.GetChatCompletions(chatCompletionsOptions);

            ChatResponseMessage responseMessage = response.Value.Choices[0].Message;

            return responseMessage;

        }



    }
}
