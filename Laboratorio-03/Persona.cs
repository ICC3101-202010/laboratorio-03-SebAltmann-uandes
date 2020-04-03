using System;
namespace Laboratorio03
{
    public class Persona
    {
        private string RUT;
        private string nombre;
        private string apellido;
        private string nacimiento;
        private string nacionalidad;

        public Persona(String RUT, String nombre, String apellido, String nacimiento, String nacionalidad)
        {
            this.RUT = RUT;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nacionalidad = nacionalidad;
        }
    }
}
