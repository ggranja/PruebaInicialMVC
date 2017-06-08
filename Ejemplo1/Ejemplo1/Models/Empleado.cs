using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public Sexo Sexo { get; set; }
        public Boolean Activo  { get; set; }
        public String Email { get; set; }
    }
    public enum Sexo {Masculino,Femenino }
}