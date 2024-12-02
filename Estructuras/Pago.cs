using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{
    public class Pago
    {
        public string IdTransaccion { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public int MesesPagados { get; set; }
        public decimal Monto { get; set; }
        public string Observacion { get; set; }
        public int IdMiembro { get; set; }

        public Pago(string idTransaccion, DateTime fechaRealizacion, decimal monto, string observacion, int idMiembro, int mesesPagados)
        {
            IdTransaccion = idTransaccion;
            FechaRealizacion = fechaRealizacion;
            MesesPagados = mesesPagados;
            Monto = monto;
            Observacion = observacion;
            IdMiembro = idMiembro;
        }
    }
}
