namespace ClassSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vivienda vivienda = new Vivienda("Edificio","Av. Lima 333","Lima");
            Console.WriteLine(vivienda.tipo);

            vivienda.tipo = "Condominio";
            Console.WriteLine(vivienda.tipo);
        }
    }
}
