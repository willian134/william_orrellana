namespace william_orrellana;

public partial class ResumenPage : ContentPage
{
    public ResumenPage(string user, string nombre, string apellido, string edad, string fecha, string ciudad, string pais, string monto, string mensual, string total)
    {
        InitializeComponent();
        lblTopUsuario.Text = "Conectado como: " + user;

        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;
        lblMonto.Text = string.IsNullOrEmpty(monto) ? "$0.00" : "$" + monto;
        lblMensual.Text = string.IsNullOrEmpty(mensual) ? "$0.00" : "$" + mensual;
        lblTotal.Text = string.IsNullOrEmpty(total) ? "$0.00" : "$" + total;
    }
}