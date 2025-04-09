using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public abstract class Profesor
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private string dedicacion;

        private static int totalProfesores = 0;

        public Profesor()
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
            this.cedula = "Sin cédula";
            this.dedicacion = "Tiempo completo";
            totalProfesores++;
        }

        public string GetNombre() => nombre;
        public string GetApellido() => apellido;
        public string GetCedula() => cedula;
        public string GetDedicacion() => dedicacion;
        public static int GetTotalProfesores() => totalProfesores;

        public void SetNombre(string nombre) => this.nombre = nombre;
        public void SetApellido(string apellido) => this.apellido = apellido;
        public void SetCedula(string cedula) => this.cedula = cedula;
        public void SetDedicacion(string dedicacion) => this.dedicacion = dedicacion;

        public void Inclusion()
        {
            Console.WriteLine($"Profesor {nombre} {apellido} incluido en el sistema.");
        }

        public void Eliminacion()
        {
            Console.WriteLine($"Profesor {nombre} {apellido} eliminado del sistema.");
            totalProfesores--;
        }

        public void Modificacion()
        {
            Console.WriteLine($"Datos del profesor {nombre} {apellido} modificados.");
        }

        public virtual string Reporte1()
        {
            return $"Profesor: {nombre} {apellido}, Cédula: {cedula}, Dedicación: {dedicacion}";
        }

        public abstract string Reporte2();

        public abstract string TipoProfesor();
    }
}
