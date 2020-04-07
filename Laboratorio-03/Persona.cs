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
        public string rol;
        public int sueldo;

        public Persona(String RUT, String nombre, String apellido, String nacimiento, String nacionalidad, String rol, int sueldo)
        {
            this.RUT = RUT;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nacionalidad = nacionalidad;
            this.rol = rol;
            this.sueldo = sueldo;
        }

        public string GetRUT()
        {
            return RUT;
        }

        public string GetName()
        {
            return nombre;
        }

        public string GetLastName()
        {
            return apellido;
        }

        public string GetDOB()
        {
            return nacimiento;
        }

        public string GetNationality()
        {
            return nacionalidad;
        }

        public string GetRole()
        {
            return rol;
        }

        public int GetSalary()
        {
            return sueldo;
        }
    }
}
