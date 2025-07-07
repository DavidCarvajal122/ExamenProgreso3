namespace ExamenProgreso3.Views;

public partial class LogsPage : ContentPage
{
    public LogsPage(ViewModels.LogsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as ViewModels.LogsViewModel)?.Cargar();
    }
}
