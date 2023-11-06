using AppRpgEtecs.ViewModels.Usuarios;

namespace AppRpgEtecs.Views.Usuarios;

public partial class LocalizacaoView : ContentPage
{
    LocalizacaoViewModel viewModel;
    public LocalizacaoView()
	{
		InitializeComponent();
        viewModel = new LocalizacaoViewModel();
        BindingContext = viewModel;
        viewModel.ExibirUsuariosNoMapa();
    }
}