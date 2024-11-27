
using JaguarGymApp_Preview.Estructuras;
using System;
using System.Collections.Generic;

namespace estadisticasForm
{
    internal class PoblarModelo
    {
        // Poblar con datos de ejemplo para pruebas
        public static List<Pago> ObtenerPagosDeEjemplo()
        {
            return new List<Pago>
            {
                new Pago(1, "T001", new DateTime(2024, 10, 15), "Membresía1", 100, "PagoAnual1", 1) , new Pago(2, "T002", new DateTime(2024, 9, 15), "Membresía2", 200, "PagoAnual2", 3),
                new Pago(3, "T003", new DateTime(2024, 12, 15), "Membresía3", 300, "PagoAnual3", 3)
            };
        }

        public static List<Miembro> ObtenerMiembrosDeEjemplo()
        {
            return new List<Miembro>
            {
                /* new Miembro { IdMiembro = 1, Identificacion = "ID001",CIF = "ID001", Nombres = "Juan", Apellidos = "Pérez", FechaNac = new DateTime(1990, 5, 15), FechaExp = new DateTime(2025, 5, 15), Carrera = "Ingeniería", Facultad = "Facultad de Ingeniería",  Genero = true, Interno = true, Colaborador = false, Cargo = "Estudiante" },
         new Miembro { IdMiembro = 2, Identificacion = "ID002",CIF = "ID002", Nombres = "Ana", Apellidos = "Gómez", FechaNac = new DateTime(1992, 8, 20), FechaExp = new DateTime(2026, 8, 20), Carrera = "Medicina", Facultad = "Facultad de Medicina", Genero = false, Interno = false, Colaborador = true, Cargo = "Profesor" },
         new Miembro { IdMiembro = 3, Identificacion = "ID003",CIF = "ID003", Nombres = "Carlos", Apellidos = "Sánchez", FechaNac = new DateTime(1991, 11, 12), FechaExp = new DateTime(2024, 11, 12), Carrera = "Derecho", Facultad = "Facultad de Derecho",Genero = true, Interno = true, Colaborador = false, Cargo = "Estudiante" }
                };
                }*/
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
