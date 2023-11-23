namespace SOPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaPerros listaPerros = new ListaEnlazadaPerros();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese los detalles del perro:");

                Console.Write("Color: ");
                string color = Console.ReadLine();

                Console.Write("Número de patas: ");
                int numeroDePatas = int.Parse(Console.ReadLine());

                Console.Write("Raza: ");
                string raza = Console.ReadLine();

                Perro nuevoPerro = new Perro(color, numeroDePatas, raza);
                listaPerros.AgregarPerro(nuevoPerro);
            }

            Console.WriteLine("\nLista de perros:");
            listaPerros.ImprimirLista();
        }
    }
}