using ClassSample.Models;

namespace ClassSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vivienda vivienda = new Vivienda("Av. Lima 333","Lima");
            //Console.WriteLine(vivienda.tipo);

            vivienda.tipo = "Condominio";
            Console.WriteLine(vivienda.tipo);
            Console.WriteLine(vivienda.direccion);
            Console.WriteLine(vivienda.distrito);

            Persona persona1=new Persona(1,"Carlos Carrion",101);
            Console.WriteLine(persona1.identificacion);
            Console.WriteLine(persona1.nombre);
            Console.WriteLine(persona1.departamento);

            Documento documento = new Documento("Boleta", "B01-001", 239.75);
            Console.WriteLine(documento.tipo);
            Console.WriteLine(documento.correlativo);
            Console.WriteLine(documento.valor);
        }
    }
}
