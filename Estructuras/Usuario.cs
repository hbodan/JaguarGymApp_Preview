using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarGymApp_Preview.Estructuras
{

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }

        public Usuario(int id, string nombre, string carrera)
        {
            Id = id;
            Nombre = nombre;
            Carrera = carrera;
        }

        private List<Usuario> usuarios;


    }

}
