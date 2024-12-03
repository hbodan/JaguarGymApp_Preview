using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{
    public class CambioDeRol
    {
        public int IdCambioRol { get; set; }
        public int IdMiembro { get; set; }
        public string RolAnterior { get; set; }
        public string RolNuevo { get; set; }
        public DateTime FechaCambio { get; set; }
        public string Observacion { get; set; }


        public CambioDeRol(int idCambioRol, int idMiembro, string rolAnterior, string rolNuevo, DateTime fechaCambio, string observacion)
        {
            IdCambioRol = idCambioRol;
            IdMiembro = idMiembro;
            RolAnterior = rolAnterior;
            RolNuevo = rolNuevo;
            FechaCambio = fechaCambio;
            Observacion = observacion;
        }
    }
}
