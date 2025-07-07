using System;

using SQLite;

namespace ControlSuscripciones.Models
{
    public class Suscripcion
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Servicio { get; set; }
        public string CorreoAsociado { get; set; }
        public decimal CostoMensual { get; set; }
        public bool RenovacionAutomatica { get; set; }
    }
}
