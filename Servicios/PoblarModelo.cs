
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaguarGymApp_Preview.Formularios;
using static estadisticasForm.EstructuraModelo;
using static estadisticasForm.PoblarModelo;

namespace estadisticasForm
{
    internal class PoblarModelo
    {
        // Poblar con datos de ejemplo para pruebas
        public static List<Pago> ObtenerPagosDeEjemplo()
        {
            return new List<Pago>
            {
                new Pago { IdPago = 1, IdTransaccion = "T001", FechaRealizacion = new DateTime(2024, 10, 15), Descripcion = "Membresía", Monto = 100, Observacion = "Pago anual", IdMiembro = 1 },
                new Pago { IdPago = 2, IdTransaccion = "T002", FechaRealizacion = new DateTime(2024, 11, 10), Descripcion = "Donación", Monto = 50, Observacion = "Donación mensual", IdMiembro = 2 },
                new Pago { IdPago = 3, IdTransaccion = "T003", FechaRealizacion = new DateTime(2024, 12, 5), Descripcion = "Membresía", Monto = 120, Observacion = "Pago anual", IdMiembro = 1 }
            };
        }

        public static List<Miembro> ObtenerMiembrosDeEjemplo()
        {
            return new List<Miembro>
            {
                new Miembro { IdMiembro = 1, Identificacion = "ID001", Nombres = "Juan", Apellidos = "Pérez", FechaNac = new DateTime(1990, 5, 15), Carrera = "Ingeniería", Facultad = "Facultad de Ingeniería", FechaExp = new DateTime(2025, 5, 15), Interno = true, Colaborador = false, Cargo = "Estudiante" },
                new Miembro { IdMiembro = 2, Identificacion = "ID002", Nombres = "Ana", Apellidos = "Gómez", FechaNac = new DateTime(1992, 8, 20), Carrera = "Medicina", Facultad = "Facultad de Medicina", FechaExp = new DateTime(2026, 8, 20), Interno = false, Colaborador = true, Cargo = "Profesor" },
                new Miembro { IdMiembro = 3, Identificacion = "ID003", Nombres = "Carlos", Apellidos = "Sánchez", FechaNac = new DateTime(1991, 11, 12), Carrera = "Derecho", Facultad = "Facultad de Derecho", FechaExp = new DateTime(2024, 11, 12), Interno = true, Colaborador = true, Cargo = "Estudiante" }
            };
        }

        public static List<Entrada> ObtenerEntradasDeEjemplo()
        {
            return new List<Entrada>
            {
                new Entrada { IdEntrada = 1, IdMiembro = 1, Fecha = new DateTime(2024, 11, 15), Hora = new TimeSpan(8, 30, 0) },
                new Entrada { IdEntrada = 2, IdMiembro = 2, Fecha = new DateTime(2024, 11, 15), Hora = new TimeSpan(9, 0, 0) },
                new Entrada { IdEntrada = 3, IdMiembro = 3, Fecha = new DateTime(2024, 11, 15), Hora = new TimeSpan(9, 30, 0) }
            };
        }

        public static List<CambioDeRol> ObtenerCambiosDeRolDeEjemplo()
        {
            return new List<CambioDeRol>
            {
                new CambioDeRol { IdCambioRol = 1, IdMiembro = 1, RolAnterior = "Estudiante", RolNuevo = "Colaborador", FechaCambio = new DateTime(2024, 10, 15), Observacion = "Cambio de rol para colaboración" },
                new CambioDeRol { IdCambioRol = 2, IdMiembro = 2, RolAnterior = "Profesor", RolNuevo = "Colaborador", FechaCambio = new DateTime(2024, 11, 1), Observacion = "Cambio de rol para colaboración" }
            };
        }
    }
}
