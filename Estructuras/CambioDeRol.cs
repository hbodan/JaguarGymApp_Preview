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
    }
}
