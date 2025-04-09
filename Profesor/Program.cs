using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Contratado contratado1 = new Contratado();
            Contratado contratado2 = new Contratado();
            contratado2.SetNombre("Juan");
            contratado2.SetApellido("Pérez");
            contratado2.SetFechaIngreso(new DateTime(2023, 5, 15));
            contratado2.SetFechaFinContrato(new DateTime(2024, 5, 14));

            Ordinario ordinario1 = new Ordinario();
            Ordinario ordinario2 = new Ordinario();
            ordinario2.SetNombre("María");
            ordinario2.SetApellido("González");
            ordinario2.SetAñosServicio(12);

            
            Profesor[] profesores = { contratado1, contratado2, ordinario1, ordinario2 };


            foreach (Profesor profesor in profesores)
            {
                Console.WriteLine(profesor.Reporte1());
                Console.WriteLine(profesor.Reporte2());
                Console.WriteLine($"Tipo: {profesor.TipoProfesor()}");
                profesor.Inclusion();
                Console.WriteLine();
            }

            Console.WriteLine($"Total de profesores en el sistema: {Profesor.GetTotalProfesores()}");

            
            Console.WriteLine("\nOPERACIONES ADICIONALES:");
            Console.WriteLine("\n");

            profesores[0].Modificacion();
            profesores[3].Eliminacion();

            Console.WriteLine($"\nTotal de profesores actualizado: {Profesor.GetTotalProfesores()}");

            Console.ReadKey();
        }
    }
}