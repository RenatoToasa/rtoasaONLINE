using System.Globalization;

namespace rtoasaS2.Vistas;

public partial class vInicio : ContentPage
{
	public vInicio(string usuario)
	{
		InitializeComponent();
		DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
		lblUsuario.Text = "Usuario conectado: " + usuario;// comentario
	}

    private void btnPicker_Clicked(object sender, EventArgs e)
    {
		if (pkCiudades.SelectedIndex == -1)
		{
			DisplayAlert("Alerta", "No existe dato", "Cerrar");
		}
		else
		{
            string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString(); //0-1-2
            DisplayAlert("Alerta", "El elemento seleccionado es "+dato, "Cerrar");
        }
		
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
		lblFecha.Text = "La fecha seleccionada es " + fecha;
    }

    private void pkCiudades_SelectedIndexChanged(object sender, EventArgs e)
    {
		txtDato.Text = "";
    }
}