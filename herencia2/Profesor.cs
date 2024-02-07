using System;
public class Profesor : Persona
  {
    public string Asignatura { get; set; }

    public new void Imprimir()
    {
        base.Imprimir();
        Console.WriteLine($"Asignatura: {Asignatura}");
    }
}