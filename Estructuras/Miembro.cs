using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{
    public class Miembro
    {
        public int IdMiembro { get; set; }
        public string Identificacion { get; set; }
        public string CIF { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        public DateTime FechaExp { get; set; }
        public int? Carrera { get; set; } // Opcional
        public int? Facultad { get; set; } // Opcional
        public bool Genero { get; set; }
        public bool Interno { get; set; }
        public bool Colaborador { get; set; }
        public string Cargo { get; set; } // Opcional

        public Miembro() { }

        public Miembro(int idMiembro, string identificacion, string cif, string nombres, string apellidos,
                       DateTime fechaNac, DateTime fechaExp, int? carrera, int? facultad, bool genero,
                       bool interno, bool colaborador, string cargo)
        {
            IdMiembro = idMiembro;
            Identificacion = identificacion;
            CIF = cif;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNac = fechaNac;
            FechaExp = fechaExp;
            Carrera = carrera; // Puede ser null
            Facultad = facultad; // Puede ser null
            Genero = genero;
            Interno = interno;
            Colaborador = colaborador;
            Cargo = cargo; // Puede ser null
        }
    }

}