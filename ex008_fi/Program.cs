using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex008_fi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fes el mateix programa amb FI = null i dades procedents de fitxer NUMEROS.TXT.
            //Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran  i el valor més petit 

            //Declaracio de variables
            string linia;
            int numero, numMaj, numMin;
            StreamReader fitxer = new StreamReader(@"..\..\..\..\NUMEROS.txt");
            linia = fitxer.ReadLine();
            numero = Convert.ToInt32(linia);

            numMaj = numero;
            numMin = numero;


            //Algoritme
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                if (numero > numMaj)
                    numMaj = numero;

                else if (numero < numMin)
                    numMin = numero;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"El valor més alt és: {numMaj} i el més petit és: {numMin}");

        }
    }
}
