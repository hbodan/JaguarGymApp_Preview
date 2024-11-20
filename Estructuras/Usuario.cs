using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{
    public class Usuario
    {
            public int IdMiembro { get; set; }
            public string Identificacion { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Carrera { get; set; }
            public string Facultad { get; set; }
            public bool Interno { get; set; }
            public bool Colaborador { get; set; }

        public Usuario(int idMiembro, string identificacion, string nombres, string apellidos, string carrera, string facultad, bool interno, bool colaborador)
        {
            IdMiembro = idMiembro;
            Identificacion = identificacion;
            Nombres = nombres;
            Apellidos = apellidos;
            Carrera = carrera;
            Facultad = facultad;
            Interno = interno;
            Colaborador = colaborador;
        }
    }
}
