using Microsoft.Extensions.DependencyInjection;

namespace MauiApp10
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            window.Width = 300;
            window.Height = 300;
            window.Title = "Pierwszy program";

            return window;
        }
    }
}