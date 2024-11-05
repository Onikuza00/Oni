namespace ex006_tx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA de variables
            string linia;
            int numero, i = 0, acum = 0;
            StreamReader fitxer = new StreamReader(@"..\..\..\..\NUMEROS.txt");
            linia = fitxer.ReadLine();

            //Algoritme
            numero = Convert.ToInt32(linia);

            while (linia != null)
            {
                i++;
                acum += i;
                Console.WriteLine(linia);
                linia = fitxer.ReadLine();
            }
            fitxer.Close();

            //Sortida de la informació
            Console.WriteLine($"La mitjana dels valors introduits és: {acum} ");



        }
    }
}
