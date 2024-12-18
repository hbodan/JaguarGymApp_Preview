﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{
    public class Pago
    {
        public int IdPago { get; set; }               
        public string IdTransaccion { get; set; }      
        public DateTime FechaRealizacion { get; set; } 
        public string Descripcion { get; set; }       
        public decimal Monto { get; set; }            
        public string Observacion { get; set; }      
        public int IdUsuario { get; set; }            
        public int IdMiembro { get; set; }      

        // Constructor adaptado a la estructura de la tabla
        public Pago(int idPago, string idTransaccion, DateTime fechaRealizacion, string descripcion,
                    decimal monto, string observacion, int idUsuario, int idMiembro)
        {
            IdPago = idPago;
            IdTransaccion = idTransaccion;
            FechaRealizacion = fechaRealizacion;
            Descripcion = descripcion;
            Monto = monto;
            Observacion = observacion;
            IdUsuario = idUsuario;
            IdMiembro = idMiembro;
        }
    }
}
