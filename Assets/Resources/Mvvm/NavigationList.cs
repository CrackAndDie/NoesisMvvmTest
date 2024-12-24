using System.Collections.Generic;
using XamlUiTest.Mvvm.ViewModels.MainMenu;

namespace Assets.Resources.Mvvm
{
    internal static class NavigationList
    {
        public static readonly List<NavigationContext> NavigationContexts = new List<NavigationContext>()
        {
            new NavigationContext(NavigationPage.MainMenuPage1, "MainMenu/MainMenuPage1", typeof(MainMenuPage1ViewModel)),
            new NavigationContext(NavigationPage.MainMenuPage2, "MainMenu/MainMenuPage2", typeof(MainMenuPage2ViewModel)),
        };
    }
}
