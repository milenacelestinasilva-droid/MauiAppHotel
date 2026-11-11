using MauiAppHotel.Views;

namespace MauiAppHotel;

// CÓDIGO NOVO E CORRIGIDO
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // A linha MainPage foi removida daqui!
    }

    // Adicione este bloco abaixo:
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new NavigationPage(new Views.ContratacaoHospedagem()));
    }

}
