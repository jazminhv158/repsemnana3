

namespace s3jherreraclase.Views;

public partial class vUno : ContentPage
{
    //VARIABBLESSSSSS-GLOBALES
    string usuarioglobal="a";
    string contrasenaglobal;

    public vUno()
	{
		InitializeComponent();
	}

    public vUno(string usuarioacceso, string constrasenaacceso)
    {
        InitializeComponent();
        usuarioglobal = usuarioacceso;
        contrasenaglobal = constrasenaacceso;
    }


    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		try
		{
			//DATOSS DE ACCEEESSOOO
			
			string usuario = txtUsuario.Text;
			string contrasena = txtContraena.Text;

			if (usuario == usuarioglobal && contrasena == contrasenaglobal) 
			{
				Navigation.PushAsync(new vDos(usuario, contrasena));
			}
			else
			{
				DisplayAlert("error ", "Usuario o contraseña incorrecto", "ok");
			}
		}

		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);

		}

    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vTres());

    }
}