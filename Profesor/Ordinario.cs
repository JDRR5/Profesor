using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class Ordinario : Profesor
    {
        private int añosServicio;

        public Ordinario()
        {
            SetNombre("Profesor");
            SetApellido("Ordinario");
            SetCedula("9876543210");
            SetDedicacion("Tiempo completo");
            this.añosServicio = 5;
        }

        public int GetAñosServicio() => añosServicio;
        public void SetAñosServicio(int añosServicio) => this.añosServicio = añosServicio;

        public override string Reporte1()
        {
            return $"Profesor Ordinario: {GetNombre()} {GetApellido()}, Cédula: {GetCedula()}, Dedicación: {GetDedicacion()}";
        }

        public override string Reporte2()
        {
            return $"Años de Servicio: {añosServicio}, Antigüedad: {(añosServicio > 10 ? "Alta" : añosServicio > 5 ? "Media" : "Baja")}";
        }

        public override string TipoProfesor()
        {
            return "Ordinario";
        }
    }
}
