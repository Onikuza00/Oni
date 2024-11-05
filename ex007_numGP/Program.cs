namespace ex004_fitxers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Fer un programa que vagi demanant números fins trobar el zero i ens digui el valor més gran  i el valor més petit 

            //Declaracio de variables
            int num, numMaj, numMen;

            //entrada de la info
            Console.WriteLine("Escriu el primer valor:");
            num = Convert.ToInt32(Console.ReadLine());

            numMaj = num;
            numMen = num;

           //mentre no final
            while (num != 0)
            {
                if (num > numMaj)
                    numMaj = num;
                else if (num < numMen)
                    numMen = num;

                //Demanar el seguent valor
                Console.WriteLine("Escriu el seguent valor:");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"El valor més alt és: {numMaj} i el més petit és: {numMen}");

        }
    }
}
