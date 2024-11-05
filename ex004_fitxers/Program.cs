namespace ex004_fitxers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT
            //Fes un programa per a saber quants valors positius i negatius hem introduït per teclat

            //Declaracio de variables
            string linia;
            int numero, contP = 0, contN = 0;
            StreamReader fitxer = new StreamReader(@"..\..\..\..\NUMEROS.txt");

            linia = fitxer.ReadLine();

            numero = Convert.ToInt32(linia);

            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                Console.WriteLine(numero);
                if (numero < 0)   //Els numeros son els numeros del fitxer, que els hem convertit a Int32
                    contN++;
                else contP++;

                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"cont pos: {contP} i  {contN} cont neg.");
        }
    }
}

