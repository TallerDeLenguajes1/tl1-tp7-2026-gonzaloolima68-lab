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
        private string _nombre;

        public string Nombre
        {
            get{return _nombre;}
            set{_nombre =value;}
        }
        private string _apellido;

        public string Apellido
        {
            get{return _apellido;}
            set{_apellido=value;}
        }

        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get{return _fechaNacimiento;}
            set{_fechaNacimiento =value;}
        }

        private DateTime _fechaIngreso;

        public DateTime FechaIngreso
        {
            get{return _fechaIngreso;}
            set{_fechaIngreso =value;}
        }

        private char _estado;

        public char Estado
        {
            get{return _estado;}
            set{_estado = value;}
        }

        private double _sueldo;

        public double Sueldo
        {
            get{return _sueldo;}
            set{_sueldo = value;}
        }

        private cargos _cargo;

        public cargos Cargo
        {
            get{return _cargo;}
            set{_cargo=value;}
        }


        //punto 2a

        public int Edad()
        {
            int edad= DateTime.Now.Year - FechaNacimiento.Year;

            if (DateTime.Now < FechaNacimiento.AddYear(edad))
            {
                edad--;
            }
            return edad;
        }

        public int Antiguedad()
        {
            int antiguedad=DateTime.Now.Year - FechaIngreso.Year;

            if (DateTime.Now < FechaIngreso.AddYears(antiguedad))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public Añosfaltantes()
        {
            int faltan=65 - Edad;

            if (faltan > 0)
            {
                return faltan;
            }
            else
            {
                return 0;
            }
        }


    }
}
