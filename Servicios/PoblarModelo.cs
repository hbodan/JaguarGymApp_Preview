
using JaguarGymApp_Preview.Servicios;
using JaguarGymApp_Preview.Estructuras;
using MySql.Data.MySqlClient;


using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using Guna.UI2.WinForms.Enums;

namespace estadisticasForm
{
    // Poblar con datos de ejemplo para pruebas



    internal class PoblarModelo
    {

        private MySqlConnection data;

        public PoblarModelo() {

            ConexionBD conn = new ConexionBD();
            data = new MySqlConnection(conn.GetConnector());
        }
        // ############################## DATOS DESDE BD  ########################### //

        public static List<Pago> ObtenerPagos()
        {
            var pagos = new List<Pago>();

            using (MySqlConnection data = new MySqlConnection(new ConexionBD().GetConnector()))
            {
                data.Open();
                string query = "SELECT idPago, idTransaccion, fechaRealizacion, descripcion, monto, observacion, idUsuario, idMiembro FROM Pago";

                using (MySqlCommand command = new MySqlCommand(query, data))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pagos.Add(new Pago(
                                idPago : Convert.ToInt32(reader["idPago"]),
                                idTransaccion : reader["idTransaccion"].ToString(),
                                fechaRealizacion : Convert.ToDateTime(reader["fechaRealizacion"]),
                                descripcion : reader["descripcion"].ToString(),
                                monto : Convert.ToDecimal(reader["monto"]),
                                observacion : reader["observacion"].ToString(),
                                idUsuario : Convert.ToInt32(reader["idUsuario"]),
                                idMiembro : Convert.ToInt32(reader["idMiembro"])
                            ));
                        }
                    }
                }
            }
            return pagos;
        }

        public static List<Miembro> ObtenerMiembros()
        {
            var miembros = new List<Miembro>();

            using (MySqlConnection data = new MySqlConnection(new ConexionBD().GetConnector()))
            {
                data.Open();
                string query = "SELECT idMiembro, identificacion, cif, nombres, apellidos, fechaNacimiento, fechaExp, genero, idCarrera, interno, colaborador, cargo, idFacultad FROM Miembro";

                using (MySqlCommand command = new MySqlCommand(query, data))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            miembros.Add(new Miembro(
                                idMiembro: Convert.ToInt32(reader["idMiembro"]),
                                identificacion: reader["identificacion"].ToString(),
                                cif: reader["cif"].ToString(),
                                nombres: reader["nombres"].ToString(),
                                apellidos: reader["apellidos"].ToString(),
                                fechaNac: Convert.ToDateTime(reader["fechaNacimiento"]),
                                fechaExp: Convert.ToDateTime(reader["fechaExp"]),
                                genero: Convert.ToBoolean(reader["genero"]),
                                carrera: Convert.ToInt32(reader["idCarrera"]),
                                interno: Convert.ToBoolean(reader["interno"]),
                                colaborador: Convert.ToBoolean(reader["colaborador"]),
                                cargo: reader["cargo"].ToString(),
                                facultad: Convert.ToInt32(reader["idFacultad"])
                            ));
                        }
                    }
                }
            }
            return miembros;
        }


        public static List<Entrada> ObtenerEntradas()
        {
            var entradas = new List<Entrada>();

            using (MySqlConnection data = new MySqlConnection(new ConexionBD().GetConnector()))
            {
                data.Open();
                string query = "SELECT idEntrada, idMiembro, fecha, hora FROM Entrada";

                using (MySqlCommand command = new MySqlCommand(query, data))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entradas.Add(new Entrada(
                                idEntrada: Convert.ToInt32(reader["idEntrada"]),
                                idMiembro : Convert.ToInt32(reader["idMiembro"]),
                                fecha: Convert.ToDateTime(reader["fecha"]),
                                hora : TimeSpan.Parse(reader["hora"].ToString())
                            ));
                        }
                    }
                }
            }
            return entradas;
        }

        /*

        public static List<Entrada> ObtenerCambiosDeRol()
        {
            var cambiosDeRol = new List<CambioDeRol>();

            using (MySqlConnection data = new MySqlConnection(new ConexionBD().GetConnector()))
            {
                data.Open();
                string query = "SELECT idEntrada, idMiembro, fecha, hora FROM Entrada";

                using (MySqlCommand command = new MySqlCommand(query, data))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            entradas.Add(new Entrada(
                                idEntrada: Convert.ToInt32(reader["idEntrada"]),
                                idMiembro: Convert.ToInt32(reader["idMiembro"]),
                                fecha: Convert.ToDateTime(reader["fecha"]),
                                hora: TimeSpan.Parse(reader["hora"].ToString())
                            ));
                        }
                    }
                }
            }
            return entradas;
        }



        // ############################## DATOS SINTETICOS (PREVIO A BD) ########################### //

        // Poblar con datos de ejemplo para pruebas
        public static List<Pago> ObtenerPagosDeEjemplo()
        {
            return new List<Pago>
            {
                new Pago(1, "T001", new DateTime(2024, 10, 15), "Membresía1", 100, "PagoAnual1", 1,1) , 
                new Pago(2, "T002", new DateTime(2024, 9, 15), "Membresía2", 200, "PagoAnual2", 3,1),
                new Pago(3, "T003", new DateTime(2024, 12, 15), "Membresía3", 300, "PagoAnual3", 3, 1)
            };
        }

        public static List<Miembro> ObtenerMiembrosDeEjemplo()
        {
            return new List<Miembro>
            {
                 new Miembro { IdMiembro = 1, Identificacion = "ID001",CIF = "ID001", Nombres = "Juan", Apellidos = "Pérez", FechaNac = new DateTime(1990, 5, 15), FechaExp = new DateTime(2025, 5, 15), Carrera = "Ingeniería", Facultad = "Facultad de Ingeniería",  Genero = true, Interno = true, Colaborador = false, Cargo = "Estudiante" },
         new Miembro { IdMiembro = 2, Identificacion = "ID002",CIF = "ID002", Nombres = "Ana", Apellidos = "Gómez", FechaNac = new DateTime(1992, 8, 20), FechaExp = new DateTime(2026, 8, 20), Carrera = "Medicina", Facultad = "Facultad de Medicina", Genero = false, Interno = false, Colaborador = true, Cargo = "Profesor" },
         new Miembro { IdMiembro = 3, Identificacion = "ID003",CIF = "ID003", Nombres = "Carlos", Apellidos = "Sánchez", FechaNac = new DateTime(1991, 11, 12), FechaExp = new DateTime(2024, 11, 12), Carrera = "Derecho", Facultad = "Facultad de Derecho",Genero = true, Interno = true, Colaborador = false, Cargo = "Estudiante" }
                };
                }
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
*/
    }
}

