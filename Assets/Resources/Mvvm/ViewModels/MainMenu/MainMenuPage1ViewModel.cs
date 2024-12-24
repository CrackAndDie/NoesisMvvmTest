using Assets;
using Noesis;
using System.ComponentModel;
using System.Windows.Input;
using UnityEngine;

namespace XamlUiTest.Mvvm.ViewModels.MainMenu
{
    public class MainMenuPage1ViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        public float CurrentTime { get; set; }
        public ICommand ResetTimerCommand { get; set; }

        public ICommand GoToPage2Command { get; set; }

        private float _resetTime = 0;

        public MainMenuPage1ViewModel()
        {
            ResetTimerCommand = new DelegateCommand(OnReset);
            GoToPage2Command = new DelegateCommand(OnGoToPage2);
        }

        void Start()
        {
            NoesisView view = GetComponent<NoesisView>();
            ((view.Content as Page).Content as Border).DataContext = this;
        }

        void Update()
        {
            CurrentTime = Time.realtimeSinceStartup - _resetTime;
            OnPropertyChanged("CurrentTime");
        }

        private void OnReset()
        {
            _resetTime = Time.realtimeSinceStartup;
        }

        private void OnGoToPage2()
        {
            GetComponent<MainMenuNavigatorViewModel>().Navigate(Assets.Resources.Mvvm.NavigationPage.MainMenuPage2);
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

