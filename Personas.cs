using System;

public class Class1
{
	public Class1()
	{


        namespace Personas
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Estudia()
        {
            Console.WriteLine(Nombre + " está estudiando.");
        }
    }

    public class Entrenador
    {
        public string Nombre { get; set; }

        public void HaceEjercicio()
        {
            Console.WriteLine(Nombre + " está haciendo ejercicio.");
        }
    }

}
}
