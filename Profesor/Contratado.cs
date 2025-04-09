using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class Contratado : Profesor
    {
        private DateTime fechaIngreso;
        private DateTime fechaFinContrato;

        public Contratado() : base()
        {
            SetNombre("Profesor");
            SetApellido("Contratado");
            SetCedula("1234567890");
            SetDedicacion("Medio tiempo");
            this.fechaIngreso = DateTime.Now;
            this.fechaFinContrato = DateTime.Now.AddYears(1);
        }

        public DateTime GetFechaIngreso() => fechaIngreso;
        public DateTime GetFechaFinContrato() => fechaFinContrato;

        public void SetFechaIngreso(DateTime fechaIngreso) => this.fechaIngreso = fechaIngreso;
        public void SetFechaFinContrato(DateTime fechaFinContrato) => this.fechaFinContrato = fechaFinContrato;

        public override string Reporte1()
        {
            return $"Profesor Contratado: {GetNombre()} {GetApellido()}, Cédula: {GetCedula()}, Dedicación: {GetDedicacion()}";
        }

        public override string Reporte2()
        {
            return $"Fecha de Ingreso: {fechaIngreso.ToShortDateString()}, Fecha de Fin de Contrato: {fechaFinContrato.ToShortDateString()}, Duración: {(fechaFinContrato - fechaIngreso).Days} días";
        }

        public override string TipoProfesor()
        {
            return "Contratado";
        }
    }
}
