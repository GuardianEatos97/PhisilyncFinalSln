using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhisilyncFinal.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void OnAppearing()
        {
        }

        public virtual void Initialize()
        {
        }
    }
}
