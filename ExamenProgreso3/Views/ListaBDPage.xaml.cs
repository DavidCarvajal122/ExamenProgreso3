namespace ExamenProgreso3.Views;

public partial class ListaBDPage : ContentPage
{
    public ListaBDPage(ViewModels.ListaBDViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as ViewModels.ListaBDViewModel)?.Cargar();
    }
}
