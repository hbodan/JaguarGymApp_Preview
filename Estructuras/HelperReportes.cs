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

    public class PagoReporte
    {
        public int idPago { get; set; }
        public string idTransaccion { get; set; }
        public DateTime fechaRealizacion { get; set; }
        public string descripcion { get; set; }
        public decimal monto { get; set; }
        public string observacion { get; set; }
        public string nombreUsuario { get; set; }
        public string nombreMiembro { get; set; }

        public PagoReporte(){}

        // Constructor adaptado a la estructura de la tabla
        public PagoReporte(int IdPago, string IdTransaccion, DateTime FechaRealizacion, string Descripcion,
                    decimal Monto, string Observacion, string NombreUsuario, string NombreMiembro)
        {
            idPago = IdPago;
            idTransaccion = IdTransaccion;
            fechaRealizacion = FechaRealizacion;
            descripcion = Descripcion;
            monto = Monto;
            observacion = Observacion;
            nombreUsuario = NombreUsuario;
            nombreMiembro = NombreMiembro;
        }
    }
    public class MiembroReporte
    {
        public int idMiembro { get; set; }
        public string identificacion { get; set; }
        public string cif { get; set; }
        public string nombreCompleto { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string genero { get; set; }
        public string carrera { get; set; }
        public string facultad { get; set; }
        public DateTime fechaExp { get; set; }
        public string rol { get; set; }

        public MiembroReporte() { }

        // Constructor adaptado a la estructura de la tabla
        public MiembroReporte(int IdMiembro, string Identificacion, string Cif, string NombreCompleto,
                              DateTime FechaNacimiento, string Genero, string Carrera, string Facultad,
                              DateTime FechaExp, string Rol)
        {
            idMiembro = IdMiembro;
            identificacion = Identificacion;
            cif = Cif;
            nombreCompleto = NombreCompleto;
            fechaNacimiento = FechaNacimiento;
            genero = Genero;
            carrera = Carrera;
            facultad = Facultad;
            fechaExp = FechaExp;
            rol = Rol;
        }
    }

}
