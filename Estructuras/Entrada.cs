using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{
    public class Entrada
    {
        public int IdEntrada { get; set; }
        public int IdMiembro { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

    public Entrada(int idEntrada, int idMiembro, DateTime fecha, TimeSpan hora)
        {
            IdEntrada = idEntrada;
            IdMiembro = idMiembro;
            Fecha = fecha;
            Hora = hora;
        }
    }
}
