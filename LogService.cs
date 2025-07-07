using System;

namespace ControlSuscripciones.Services
{
    public static class LogService
    {
        private static string FileName => Path.Combine(FileSystem.AppDataDirectory, "Logs_Carvajal.txt");

        public static async Task AppendLog(string servicio)
        {
            string log = $"Se incluyó el registro {servicio} el {DateTime.Now:dd/MM/yyyy HH:mm}";
            await File.AppendAllTextAsync(FileName, log + Environment.NewLine);
        }

        public static async Task<List<string>> LeerLogs()
        {
            if (!File.Exists(FileName))
                return new List<string>();

            var lineas = await File.ReadAllLinesAsync(FileName);
            return lineas.ToList();
        }
    }
}
