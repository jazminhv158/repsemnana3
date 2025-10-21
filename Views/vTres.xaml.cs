namespace s3jherreraclase.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

    private void tnSalir_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuario = txtUsuario.Text;
			string contrasena = txtContraena.Text;
			Navigation.PushAsync(new vUno(usuario, contrasena));
		}
		catch (Exception)
		{

		}

    }

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {

    }

   
}