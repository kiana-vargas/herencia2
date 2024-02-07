using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Estudiante : Persona
{
    public string Carrera { get; set; }

    public new void Imprimir()
    {
        base.Imprimir();
        Console.WriteLine($"Carrera: {Carrera}");
    }
}
