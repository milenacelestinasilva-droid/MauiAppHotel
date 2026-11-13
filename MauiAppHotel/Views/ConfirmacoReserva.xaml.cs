
namespace MauiAppHotel.Views;

public partial class ConfirmacaoReserva : ContentPage
{
    public ConfirmacaoReserva(string nome, string telefone,
                               string email, string cpf)
    {
        InitializeComponent();

        lblNome.Text = nome;
        lblTelefone.Text = telefone;
        lblEmail.Text = email;
    }

    private async void OnFinalizarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Maui App Hotel",
            "Obrigado! Demonstração finalizada.",
            "OK");

        await Navigation.PopToRootAsync();
    }
}
