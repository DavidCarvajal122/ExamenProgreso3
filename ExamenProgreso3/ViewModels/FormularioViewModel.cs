using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenProgreso3.Models;
using ExamenProgreso3.Services;

namespace ExamenProgreso3.ViewModels
{
    public partial class FormularioViewModel : ObservableObject
    {
        [ObservableProperty] private string servicio;
        [ObservableProperty] private string correo;
        [ObservableProperty] private decimal costo;
        [ObservableProperty] private bool renovacion;

        [RelayCommand]
        public async Task Guardar()
        {
            if (((int)costo) % 2 == 0)
            {
                await Shell.Current.DisplayAlert("Error", "El costo mensual debe ser impar");
                return;
            }

            var nueva = new Suscripcion
            {
                Servicio = servicio,
                CorreoAsociado = correo,
                CostoMensual = costo,
                RenovacionAutomatica = renovacion
            };

            var db = new DatabaseService();
            await db.AddSuscripcion(nueva);
            await LogService.AppendLog(servicio);

            await Shell.Current.DisplayAlert("Éxito", "Suscripción guardada");

            Servicio = string.Empty;
            Correo = string.Empty;
            Costo = 0;
            Renovacion = false;
        }
    }
}
