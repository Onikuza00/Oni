namespace ex012_alum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Donat el fitxer alumnesDAMDAW.txt al moodle, recorre el fitxer per determinar si hi ha més alumnes que es diuen Alex o més alumnes Iker…
            string linia;
            int contAlex = 0, contIker = 0, i = 0;
            StreamReader fitxer = new StreamReader(@"..\..\..\..\alumnesDAMDAW.txt");
            linia = fitxer.ReadLine();

            while (linia != null)
            {
                if (linia == "Alex") contAlex++;
                else if (linia == "Iker") contIker++;
                i++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            if (contAlex == contIker)
                Console.WriteLine("Hi ha la mateixa quantitat de Ikers i Alexs");
            else if (contAlex > contIker)
                Console.WriteLine("Hi ha més Alexs que Ikers");
            else
                Console.WriteLine("Hi ha més Ikers que Alexs");
        }

        }
}
