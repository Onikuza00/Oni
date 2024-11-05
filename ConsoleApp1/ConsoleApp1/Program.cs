namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Fes un programa per contar quants valors enters introdueix un usuari per Consola. Deixarem
            de contar valors en trobar el valor 0.
            Quin és el primer element que tractarem?
            Quina és la condició de final de recorregut?
            */

            //Declaració de variables
            int valor1 = 0;
            int cont = 0;
            int valor;

            //Introducció de la informació
            Console.WriteLine("escriu el valor que vulguis:");
            valor = Convert.ToInt32(Console.ReadLine());

            //Bucle + Algoitme
            while (valor != valor1)
            {
                cont++;
                Console.WriteLine("Torna a escriure el valor que vulguis:");
                valor = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Felicitats has trobat el valor indicat amb {cont} intents.");
        }
    }
}
