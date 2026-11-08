using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Microsoft.Maui.Controls.Window CreateWindow(IActivationState? activationState)
        {
            var window = new Microsoft.Maui.Controls.Window(new AppShell());
            window.Width = 400;
            window.Height = 600;
            return window;
        }

    }
}