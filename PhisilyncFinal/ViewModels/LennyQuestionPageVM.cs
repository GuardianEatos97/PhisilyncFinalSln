using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Mvvm.Input;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services.LennyAI.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PhisilyncFinal.LennyAIEnums;

namespace PhisilyncFinal.ViewModels
{
    public partial class LennyQuestionPageVM:BaseViewModel
    {
        private IAiAssistant _assistant;
        private ObservableCollection<LennyAIChatMessage> _chatHistory;

        public ObservableCollection<LennyAIChatMessage> ChatHistory
        {
            get { return _chatHistory; }
            set
            {
                _chatHistory = value;

                OnPropertyChanged();
            }
        }

        private string _currentQuestion;
        public string CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                _currentQuestion = value;

                OnPropertyChanged();
            }
        }

        public LennyQuestionPageVM(IAiAssistant assistant)
        {
            _assistant = assistant;

            ChatHistory = new ObservableCollection<LennyAIChatMessage>();
            ChatHistory.Add(new LennyAIChatMessage { MessageType = LennyAIEnums.ChatMessageEnums.Inbound, MessageBody = "Hi Im Lenny! Your friendly Phyisilync Assistant. How Can I Help You?" });
        }

        [RelayCommand]
        public async Task ChatSelected(LennyAIChatMessage message)
        {
            var navigationParameter = new Dictionary<string, object>
        {
         { "Response", message }
           };
           // await Shell.Current.GoToAsync($"loadsheddinganswer", navigationParameter);

        }

        [RelayCommand]
        public async Task AskQuestion(ITextInput view, CancellationToken token)
        {
             /* QuestionResponseModel model = new QuestionResponseModel();
              model.Answer = "Hello, World!";
              var navigationParameter = new Dictionary<string, object>
      {
          { "Response", model }
      };
              await Shell.Current.GoToAsync($"loadsheddinganswer", navigationParameter);
            */



            var inboundMessages = ChatHistory.Where(x => x.MessageType == LennyAIEnums.ChatMessageEnums.Inbound).ToList();

            var currentChatMessage = new LennyAIChatMessage { MessageType = LennyAIEnums.ChatMessageEnums.Outbound, MessageBody = CurrentQuestion };

            try
            {
                var response = _assistant.GetCompletion(inboundMessages, currentChatMessage);
                ChatHistory.Add(currentChatMessage);

                var responseChatMessage = new LennyAIChatMessage { MessageType = LennyAIEnums.ChatMessageEnums.Inbound, MessageBody = response.Content };
                ChatHistory.Add(responseChatMessage);


                CurrentQuestion = string.Empty;
            }
            catch (Exception ex)
            {

            }
            bool isSuccessful = await view.HideKeyboardAsync(token);
        }


    }
}
