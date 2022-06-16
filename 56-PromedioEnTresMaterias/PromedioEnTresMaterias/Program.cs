using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromedioEnTresMaterias
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un alumno desea saber cual será su promedio general en las tres materias mas difíciles que cursa y cual será el promedio que obtendrá en cada una de ellas. Estas materias se evalúan como se muestra a continuación:
             * La calificación de Matemáticas se obtiene de la sig. manera:
             * Examen 90%
             * Promedio de tareas 10%
             * En esta materia se pidió un total de tres tareas.

             * La calificación de Física se obtiene de la sig. manera:
             * Examen 80%
             * Promedio de tareas 20%
             * En esta materia se pidió un total de dos tareas.

             * La calificación de Química se obtiene de la sig. manera:
             * Examen 85%
             * Promedio de tareas 15%
             * En esta materia se pidió un promedio de tres tareas.*/

            double tareaMate_1, tareaMate_2, tareaMate_3, exMate, pMater, promMate;

            Console.CursorLeft = 30;
            Console.WriteLine("NOTAS DE MATEMATICAS");

            Console.Write(" Nota de tarea No. 1 : ");
            tareaMate_1 = Double.Parse(Console.ReadLine());
            Console.Write(" Nota de tarea No. 2 : ");
            tareaMate_2 = Double.Parse(Console.ReadLine());
            Console.Write(" Nota de tarea No. 3 : ");
            tareaMate_3 = Double.Parse(Console.ReadLine());

            Console.Write("\n Nota de examen : ");
            exMate = Double.Parse(Console.ReadLine());

            pMater = ((tareaMate_1 + tareaMate_2 + tareaMate_3) / 3) * 0.1;
            exMate = exMate * 0.9;

            Console.WriteLine("\n El promedio de matemáticas es : {0:G2}", promMate = exMate + pMater);

            double tareaFisica_1, tareaFisica_2, exFisica, pFisica, promFisica;

            Console.CursorLeft = 32;
            Console.WriteLine("NOTAS DE FISICA");

            Console.Write(" Nota de tarea No. 1 : ");
            tareaFisica_1 = Double.Parse(Console.ReadLine());
            Console.Write(" Nota de tarea No. 2 : ");
            tareaFisica_2 = Double.Parse(Console.ReadLine());

            Console.Write("\n Nota de examen : ");
            exFisica = Double.Parse(Console.ReadLine());

            pFisica = ((tareaFisica_1 + tareaFisica_2) / 2) * 0.2;
            exFisica = exFisica * 0.8;

            Console.WriteLine("\n El promedio de matemáticas es : {0:G2}",
                promFisica = exFisica + pFisica);

            double tareaQuim_1, tareaQuim_2, tareaQuim_3, exQuim, pQuim, promQuim;

            Console.CursorLeft = 31;
            Console.WriteLine("NOTAS DE QUIMICA");

            Console.Write(" Nota de tarea No. 1 : ");
            tareaQuim_1 = Double.Parse(Console.ReadLine());
            Console.Write(" Nota de tarea No. 2 : ");
            tareaQuim_2 = Double.Parse(Console.ReadLine());
            Console.Write(" Nota de tarea No. 3 : ");
            tareaQuim_3 = Double.Parse(Console.ReadLine());

            Console.Write("\n Nota de examen : ");
            exQuim = Double.Parse(Console.ReadLine());

            pQuim = ((tareaQuim_1 + tareaQuim_2 + tareaQuim_3) / 3) * 0.15;
            exQuim = exQuim * 0.85;

            Console.WriteLine("\n El promedio de matemáticas es : {0:G2}", promQuim = exQuim + pQuim);

            double pGeneral;
            Console.WriteLine("\n El promedio general de las tres materias es {0:G2} ", pGeneral = (promMate + promFisica + promQuim) / 3);

            Console.ReadKey();
        }
    }
}
