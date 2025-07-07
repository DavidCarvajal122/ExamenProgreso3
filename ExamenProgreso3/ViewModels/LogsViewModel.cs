using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ExamenProgreso3.Services;

namespace ExamenProgreso3.ViewModels
{
    public partial class LogsViewModel : ObservableObject
    {
        public ObservableCollection<string> Logs { get; set; } = new();

        public async void Cargar()
        {
            Logs.Clear();
            var lineas = await LogService.LeerLogs();
            foreach (var l in lineas)
                Logs.Add(l);
        }
    }
}
