
namespace MauiAppHotel.Views;

public partial class DadosHospede : ContentPage
{
    public DadosHospede()
    {
        InitializeComponent();
    }

    private async void OnContinuarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text) ||
            string.IsNullOrWhiteSpace(txtTelefone.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtCPF.Text))
        {
            await DisplayAlert("Atenção",
                "Preencha todos os campos.",
                "OK");
            return;
        }

        await Navigation.PushAsync(new ConfirmacaoReserva(
            txtNome.Text,
            txtTelefone.Text,
            txtEmail.Text,
            txtCPF.Text));
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
