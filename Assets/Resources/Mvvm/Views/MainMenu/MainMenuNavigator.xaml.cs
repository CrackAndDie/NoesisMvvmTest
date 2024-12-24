#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace XamlUiTest.Mvvm.Views.MainMenu
{
    public partial class MainMenuNavigator : Page
    {
        public MainMenuNavigator()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this, "Assets/Resources/Mvvm/Views/MainMenu/MainMenuNavigator.xaml");
        }
#endif
    }
}
