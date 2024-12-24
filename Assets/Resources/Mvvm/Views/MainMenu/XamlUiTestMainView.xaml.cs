#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace XamlUiTest.Mvvm.Views.MainMenu
{
    public partial class XamlUiTestMainView : UserControl
    {
        public XamlUiTestMainView()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this, "Assets/Resources/Mvvm/Views/MainMenu/XamlUiTestMainView.xaml");
        }
#endif
    }
}
