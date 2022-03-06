using Caliburn.Micro;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace DummyWpfApp.ViewModels
{
    public class PopupViewModel : Screen
    {
        private string _userInput;

        public PopupViewModel()
        {
        }

        public string UserInput
        {
            get => _userInput;
            set
            {
                _userInput = value;
                NotifyOfPropertyChange(() => UserInput);
            }
        }

        public void TextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("TextBox_TextChanged CALLED");
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            ShowOrHide();
        }

        public void ShowOrHide()
        {
            if (GetView() is Popup popup)
            {
                popup.IsOpen = !popup.IsOpen;
            }
        }
    }
}
