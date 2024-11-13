using PrevisaoTempo.ViewModels;
using PrevisaoTempo.Services;

namespace PrevisaoTempo.Views;

public partial class CidadeView : ContentPage
{
    public CidadeView()
    {
        InitializeComponent();
        BindingContext = new CidadeViewModel();
    }

    private void EntryCompleted(object sender, EventArgs e)
    {
        string NomeCidade = entry.Text;
    }
}