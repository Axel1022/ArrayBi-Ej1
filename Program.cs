/*
    Crea un programa en C# que use un array para almacenar nombres de estudiantes y sus calificaciones. Luego, demuestra cómo una estructura de datos ayuda a organizar y manipular esta información.

*/

#region Variables
int cantidad;
string nombre;
string nota;
#endregion

System.Console.Write("Ingrese la cantidad de estudiantes: ");
cantidad = int.Parse(Console.ReadLine()!);
string[,] estudiantesNota = new string[2, cantidad];


for (int i = 0; i < cantidad; i++)
{
    System.Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
    nombre = Console.ReadLine()!;
    estudiantesNota[0, i] = nombre;

    System.Console.Write($"Ingrese la nota de {estudiantesNota[0, i]}: ");
    nota = Console.ReadLine()!;
    estudiantesNota[1, i] = nota;

    Console.Clear();
}
for (int i = 0; i < cantidad; i++)
{
    System.Console.WriteLine("Reporte de calificaciones:");
    System.Console.WriteLine($"{estudiantesNota[0, i]} : {estudiantesNota[1, i]}");
    System.Console.WriteLine();
}
