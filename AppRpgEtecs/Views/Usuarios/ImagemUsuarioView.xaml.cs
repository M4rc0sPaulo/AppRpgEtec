using AppRpgEtecs.ViewModels.Usuarios;

namespace AppRpgEtecs.Views.Usuarios;

public partial class ImagemUsuarioView : ContentPage
{
    ImagemUsuarioViewModel viewModel;
    public ImagemUsuarioView()
	{
		InitializeComponent();

        viewModel = new ImagemUsuarioViewModel();
        Title = "Imagem do Usuário";
        BindingContext = viewModel;
    }
}