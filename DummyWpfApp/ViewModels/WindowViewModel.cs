using Caliburn.Micro;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace DummyWpfApp.ViewModels
{
    public class WindowViewModel : Screen
    {
        private string _userInput;

        public WindowViewModel()
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

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine("TextBox_TextChanged CALLED");
        }

        public void Close(object sender, RoutedEventArgs e)
        {
            ShowOrHide();
        }

        public void ShowOrHide()
        {
            Window window = GetView() as Window;
            if (window is not null)
            {
                if (window.IsVisible)
                {
                    window.Hide();
                }
                else
                {
                    window.Show();
                }
            }
        }
    }
}
