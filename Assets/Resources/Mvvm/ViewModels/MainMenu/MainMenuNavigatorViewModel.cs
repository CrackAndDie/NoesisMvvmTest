using Assets.Resources.Mvvm;
using Noesis;
using System.ComponentModel;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using XamlUiTest.Mvvm.Views.MainMenu;

namespace XamlUiTest.Mvvm.ViewModels.MainMenu
{
    public class MainMenuNavigatorViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        private NavigationContext _currentPage;
        private Border _navigationFrame;

        void Start()
        {
            NoesisView view = GetComponent<NoesisView>();
            view.Content.DataContext = this;
            _navigationFrame = view.Content.FindName("NavigationFrame") as Border;
            Navigate(NavigationPage.MainMenuPage1);
        }

        public void Navigate(NavigationPage page)
        {
            // clear old one
            if (_currentPage != null)
            {
                // remove vm
                Destroy(GetComponent(_currentPage.ViewModelType));
            }

            _currentPage = NavigationList.NavigationContexts.First(x => x.NavigationPage == page);
            gameObject.AddComponent(_currentPage.ViewModelType);
            var xaml = Resources.Load<NoesisXaml>($"Mvvm/Views/{_currentPage.Path}");
            _navigationFrame.Child = xaml.Load() as UIElement;
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
