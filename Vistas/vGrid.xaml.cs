namespace rtoasaS2.Vistas;

public partial class vGrid : ContentPage
{
	string usuario1;
	string contrasena1;
	public vGrid()
	{
		InitializeComponent();
	}
	public vGrid(string usuario, string contrasena)
	{
        InitializeComponent();
		usuario1=usuario;
		contrasena1 = contrasena;
    }
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		

		if (txtUsuario.Text==usuario1 && txtContrasena.Text == contrasena1)
		{
			Navigation.PushAsync(new vInicio(usuario1));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contrasena incorrectos", "Cerrar");
		}
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vRegistro());
    }
}