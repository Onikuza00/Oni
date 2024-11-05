namespace ex005_fitxers
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Fer un programa que vagi demanant per teclat números fins trobar el zero i calculi la mitjana dels valors introduïts.

            //Variables
            int numero, i = 0, acum = 0;

            //Introducció de la informació
            Console.WriteLine("Escriu el valor que vulguis:");
            numero= Convert.ToInt32(Console.ReadLine());

            //Algoritme
            while ( numero!=0)
            {
                i++;
                acum = acum + i;
                Console.WriteLine("Proba de nou amb un altre valor:");
                numero = Convert.ToInt32(Console.ReadLine());
                
            }
             //Sortida de la informació
            Console.WriteLine($"Felicitats has trobat el valor indicat, i la mitjana dels valors introduit és: {acum / 2}");
        }
    }
}
