using System;

namespace Assets.Resources.Mvvm
{
    public class NavigationContext
    {
        public NavigationPage NavigationPage { get; set; }
        public string Path { get; set; }
        public Type ViewModelType { get; set; }

        public NavigationContext(NavigationPage navigationPage, string path, Type vmType)
        {
            NavigationPage = navigationPage;
            Path = path;
            ViewModelType = vmType;
        }
    }

    public enum NavigationPage
    {
        MainMenuPage1,
        MainMenuPage2
    }
}
