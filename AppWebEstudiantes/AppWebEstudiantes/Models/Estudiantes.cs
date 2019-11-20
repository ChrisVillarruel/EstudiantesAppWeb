using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebEstudiantes.Models
{
    public class Estudiantes
    {
        public Guid     IDEstudiante    { get; set; }
        public string   Nombre          { get; set; }
        public string   apellidoPaterno { get; set; }
        public string   apellidoMaterno { get; set; }
        public float    promedio        { get; set; }
        public int      cuatrimestre    { get; set; }
        public string   correo          { get; set; }
        public int      telefono        { get; set; }
        public Int64     celular         { get; set; }
        public Guid     GUIDCarrera     { get; set; }  
        public string nombreCarrera     { get; set; }
    }
}
