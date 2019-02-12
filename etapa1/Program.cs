using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");

            imprimirCursos(engine.Escuela);
        }

        private static void imprimirCursos(Escuela escuela)
        {
            if(escuela?.Cursos!=null)
            foreach (var item in escuela.Cursos)
            {
                System.Console.WriteLine($"{item.Nombre} {item.UniqueId}");
            }
        }
    }
}