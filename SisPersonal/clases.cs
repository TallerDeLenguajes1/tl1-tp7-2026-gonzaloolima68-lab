using system;

namespace Empleados
{
    public enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }
    public class Empleado
    {
        private string nombre;

        public string Nombre
        {
            get{return nombre;}
            set{nombre =value;}
        }
        private string apellido;

        public string Apellido
        {
            get{return apellido;}
            set{apellido=value;}
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get{return fechaNacimiento;}
            set{fechaNacimiento =value;}
        }

        private DateTime fechaIngreso;

        public DateTime FechaIngreso
        {
            get{return fechaIngreso;}
            set{fechaIngreso =value;}
        }

        private char estado;

        public char Estado
        {
            get{return estado;}
            set{estado = value;}
        }

        private double sueldo;

        public double Sueldo
        {
            get{return sueldo;}
            set{sueldo = value;}
        }

        private cargos cargo;

        public cargos Cargo
        {
            get{return cargo;}
            set{cargo=value;}
        }


    }
}
