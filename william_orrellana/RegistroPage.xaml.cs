namespace william_orrellana;

public partial class RegistroPage : ContentPage
{
    string usuarioLogueado;
    double cuotaFinal = 0;
    double totalPagar = 0;

    public RegistroPage(string usuario)
    {
        InitializeComponent();
        usuarioLogueado = usuario;
        lblUsuarioConectado.Text = "Conectado como: " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double costoTotal = 1500;

            if (montoInicial < 0 || montoInicial > costoTotal)
            {
                DisplayAlert("Atención", "El monto inicial debe estar entre 0 y 1500", "OK");
                return;
            }

            double saldo = costoTotal - montoInicial;
            double interes = costoTotal * 0.04;

            cuotaFinal = (saldo / 4) + interes;
            txtPagoMensual.Text = cuotaFinal.ToString("0.00");

            totalPagar = montoInicial + (cuotaFinal * 4);
        }
        catch
        {
            DisplayAlert("Aviso", "Por favor ingrese un monto inicial válido", "OK");
        }
    }

    private async void btnResumen_Clicked(object sender, EventArgs e)
    {
        string pais = pkPais.SelectedItem != null ? pkPais.SelectedItem.ToString() : "";
        string ciudad = pkCiudad.SelectedItem != null ? pkCiudad.SelectedItem.ToString() : "";

        await Navigation.PushAsync(new ResumenPage(
            usuarioLogueado,
            txtNombre.Text,
            txtApellido.Text,
            txtEdad.Text,
            dpFecha.Date.ToString(),
            ciudad,
            pais,
            txtMontoInicial.Text,
            txtPagoMensual.Text,
            totalPagar.ToString("0.00")
        ));
    }
}