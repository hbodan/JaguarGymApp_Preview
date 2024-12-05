using JaguarGymApp_Preview.Servicios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace JaguarGymApp_Preview.Estructuras
{
    public class EntradaReporte
    {
        public int IdEntrada { get; set; }
        public string NombreMiembro { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public EntradaReporte() { }

        public EntradaReporte(int idEntrada, string miembro, DateTime fecha, TimeSpan hora)
        {
            IdEntrada = idEntrada;
            NombreMiembro = miembro;
            Fecha = fecha;
            Hora = hora;
        }
    }
}
