#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace XamlUiTest.Mvvm.Views.MainMenu
{
    public partial class MainMenuPage2 : Page
    {
        public MainMenuPage2()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this, "Assets/Resources/Mvvm/Views/MainMenu/MainMenuPage2.xaml");
        }
#endif
    }
}
