// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        //crear instancia de estudiante
        Estudiante estudiante = new Estudiante();
        Console.WriteLine("Ingrese el id del estudiante:");
        estudiante.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre del estudiante:");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la dirección del estudiante:");
        estudiante.Direccion = Console.ReadLine();
        Console.WriteLine("Ingrese el correo del estudiante:");
        estudiante.Correo = Console.ReadLine();
        Console.WriteLine("Ingrese la carrera del estudiante:");
        estudiante.Carrera = Console.ReadLine();

        // Crear instancia de Profesor
        Profesor profesor = new Profesor();
        Console.WriteLine("Ingrese el id del profesor:");
        profesor.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el nombre del profesor:");
        profesor.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la dirección del profesor:");
        profesor.Direccion = Console.ReadLine();
        Console.WriteLine("Ingrese el correo del profesor:");
        profesor.Correo = Console.ReadLine();
        Console.WriteLine("Ingrese la asignatura del profesor:");
        profesor.Asignatura = Console.ReadLine();

        // Imprimir los datos de las instancias
        Console.WriteLine("Datos del estudiante:");
        estudiante.Imprimir();
        Console.WriteLine("Datos del profesor:");
        profesor.Imprimir();
    }
}
