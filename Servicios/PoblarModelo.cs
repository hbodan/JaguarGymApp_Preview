
using JaguarGymApp_Preview.Estructuras;
using JaguarGymApp_Preview.Servicios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace estadisticasForm
{
    internal class PoblarModelo
    {
        private MySqlConnection data;

        public PoblarModelo()
        {

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
                                idPago: Convert.ToInt32(reader["idPago"]),
                                idTransaccion: reader["idTransaccion"].ToString(),
                                fechaRealizacion: Convert.ToDateTime(reader["fechaRealizacion"]),
                                descripcion: reader["descripcion"].ToString(),
                                monto: Convert.ToDecimal(reader["monto"]),
                                observacion: reader["observacion"].ToString(),
                                idUsuario: Convert.ToInt32(reader["idUsuario"]),
                                idMiembro: Convert.ToInt32(reader["idMiembro"])
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
                                interno: Convert.ToBoolean(reader["interno"]),
                                colaborador: Convert.ToBoolean(reader["colaborador"]),
                                carrera : reader["idCarrera"] != DBNull.Value ? (int?)Convert.ToInt32(reader["idCarrera"]) : null,
                                facultad : reader["idFacultad"] != DBNull.Value ? (int?)Convert.ToInt32(reader["idFacultad"]) : null,
                                cargo : reader["cargo"] != DBNull.Value ? reader["cargo"].ToString() : null));
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


    }
}
