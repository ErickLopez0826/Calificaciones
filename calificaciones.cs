using System;

class calificaciones
{
    static void Main(){
        // Entrada de las calificaciones de los alumnos
        Console.Write("Ingrese la calificacion de las practicas: ");
        double practicas = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la calificacion del examen: ");
        double examen = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la calificacion de las tareas: ");
        double tareas = Convert.ToDouble(Console.ReadLine());

        // Conficional para que el usuario ingrese valores permitidos
        if (practicas < 0 || practicas > 100 || examen < 0 || examen > 100 || tareas < 0 || tareas > 100)
        {
            Console.WriteLine("Ingrese valores que esten dentro de un rango de 0 a 100");
            return;
        }
        double calificacionTotal = (practicas * 0.55) + (examen * 0.30) + (tareas * 0.15);
        Console.WriteLine($"La calificacion del alumno es {calificacionTotal:F2}");
        // Condicional para que te diga si el alumno reprobo o aprobo
        if (calificacionTotal >= 60)
        {
            Console.WriteLine("El alumno ha aprobado.");
        }
        else
        {
            Console.WriteLine("El alumno ha reprobado.");
        }
    }
}
