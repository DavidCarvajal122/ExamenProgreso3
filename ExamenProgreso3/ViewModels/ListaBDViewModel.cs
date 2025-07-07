using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ExamenProgreso3.Models;
using ExamenProgreso3.Services;

namespace ExamenProgreso3.ViewModels
{
    public partial class ListaBDViewModel : ObservableObject
    {
        public ObservableCollection<Suscripcion> Suscripciones { get; set; } = new();

        public async void Cargar()
        {
            Suscripciones.Clear();
            var lista = await DatabaseService.ObtenerSuscripcionesAsync();
            foreach (var item in lista)
                Suscripciones.Add(item);
        }
    }
}
