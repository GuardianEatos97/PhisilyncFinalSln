using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Mvvm.Input;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services.LennyAI.Interfaces;
using System.Collections.ObjectModel;



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

            _chatHistory = new ObservableCollection<LennyAIChatMessage>();
            ChatHistory.Add(new LennyAIChatMessage { MessageType = LennyAIEnums.ChatMessageTypeEnum.Inbound, MessageBody = "Hi Im Lenny! Your friendly Phyisilync Assistant. How Can I Help You?" } );
        }

        [RelayCommand]
        public async Task ChatSelected(LennyAIChatMessage message)
        {
            var navigationParameter = new Dictionary<string, object>
        {
         { "Response", message }
        };
            await Shell.Current.GoToAsync($"AnswerPage", navigationParameter);

        }

        [RelayCommand]
        public async Task AskQuestion(ITextInput view, CancellationToken token)
        {
            var inboundMessages = ChatHistory.Where(x => x.MessageType == LennyAIEnums.ChatMessageTypeEnum.Inbound).ToList();

            var currentChatMessage = new LennyAIChatMessage { MessageType = LennyAIEnums.ChatMessageTypeEnum.Outbound, MessageBody = CurrentQuestion };

            try
            {
                var response = _assistant.GetCompletion(inboundMessages, currentChatMessage);
                ChatHistory.Add(currentChatMessage);

                var responseChatMessage = new LennyAIChatMessage { MessageType = LennyAIEnums.ChatMessageTypeEnum.Inbound, MessageBody = response.Content };
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
