using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebEstudiantes.Models
{
    public class Carrera
    {
        //Creamos el modelado para mi tabla Carrera
        public Guid GUIDCarrera { get; set; }
        public string claveCarrera { get; set; }
        public String nombreCarrera { get; set; }
    }
}
