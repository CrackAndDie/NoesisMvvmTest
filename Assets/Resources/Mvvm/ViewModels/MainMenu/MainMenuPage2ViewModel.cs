using Assets;
using Noesis;
using System.ComponentModel;
using System.Windows.Input;
using UnityEngine;

namespace XamlUiTest.Mvvm.ViewModels.MainMenu
{
    public class MainMenuPage2ViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        public ICommand GoToPage1Command { get; set; }

        public MainMenuPage2ViewModel()
        {
            GoToPage1Command = new DelegateCommand(OnGoToPage1);
        }

        void Start()
        {
            NoesisView view = GetComponent<NoesisView>();
            ((view.Content as Page).Content as Border).DataContext = this;
        }

        private void OnGoToPage1()
        {
            GetComponent<MainMenuNavigatorViewModel>().Navigate(Assets.Resources.Mvvm.NavigationPage.MainMenuPage1);
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
