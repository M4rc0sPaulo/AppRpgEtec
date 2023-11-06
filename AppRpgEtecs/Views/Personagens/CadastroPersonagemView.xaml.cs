using AppRpgEtecs.ViewModels.Personagens;

namespace AppRpgEtecs.Views.Personagens;

public partial class CadastroPersonagemView : ContentPage
{
    private CadastroPersonagemViewModel cadViewModel;
    public CadastroPersonagemView()
	{
		InitializeComponent();

        cadViewModel = new CadastroPersonagemViewModel();
        BindingContext = cadViewModel;
        Title = "Novo Personagem";
    }
}