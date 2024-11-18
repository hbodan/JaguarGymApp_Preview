using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estadisticasForm
{
    internal class EstructuraModelo
    {
        public class Pago
        {
            public int IdPago { get; set; }
            public string IdTransaccion { get; set; }
            public DateTime FechaRealizacion { get; set; }
            public string Descripcion { get; set; }
            public decimal Monto { get; set; }
            public string Observacion { get; set; }
            public int IdMiembro { get; set; }
        }

        public class Miembro
        {
            public int IdMiembro { get; set; }
            public string Identificacion { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public DateTime FechaNac { get; set; }
            public string Carrera { get; set; }
            public string Facultad { get; set; }
            public DateTime FechaExp { get; set; }
            public bool Interno { get; set; }
            public bool Colaborador { get; set; }
            public string Cargo { get; set; }
        }

        public class Entrada
        {
            public int IdEntrada { get; set; }
            public int IdMiembro { get; set; }
            public DateTime Fecha { get; set; }
            public TimeSpan Hora { get; set; }
        }

        public class CambioDeRol
        {
            public int IdCambioRol { get; set; }
            public int IdMiembro { get; set; }
            public string RolAnterior { get; set; }
            public string RolNuevo { get; set; }
            public DateTime FechaCambio { get; set; }
            public string Observacion { get; set; }
        }
    }
}
