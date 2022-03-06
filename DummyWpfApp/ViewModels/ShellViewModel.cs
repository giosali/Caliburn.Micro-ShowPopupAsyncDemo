using Caliburn.Micro;
using System.Diagnostics;
using System.Windows;

namespace DummyWpfApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
        }

        private WindowViewModel Window { get; set; } = new();

        private PopupViewModel Popup { get; set; } = new();

        public void OpenWindow(object sender, RoutedEventArgs e)
        {
            if (Window.IsActive)
            {
                Debug.WriteLine("OpenWindow: Window.IsActive = true ... ShowOrHide()");
                Window.ShowOrHide();
            }
            else
            {
                Debug.WriteLine("OpenWindow: Window.IsActive = false ... WindowManager()");
                WindowManager manager = new();
                manager.ShowWindowAsync(Window);
            }
        }

        public async void OpenPopup(object sender, RoutedEventArgs e)
        {
            if (Popup.IsActive)
            {
                Debug.WriteLine("OpenPopup: Popup.IsActive = true ... ShowOrHide()");
                Popup.ShowOrHide();
            }
            else
            {
                Debug.WriteLine("OpenPopup: Popup.IsActive = false ... WindowManager()");
                IWindowManager manager = new WindowManager();
                await manager.ShowPopupAsync(Popup);
            }
        }
    }
}
