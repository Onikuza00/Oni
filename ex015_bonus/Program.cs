using System.Text;

namespace ex015_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2.13. Un fitxer anomenat bonus.txt conté una línia per a cada bitllet de loteria venut.
            ● Cada línia indica si el bitllet és "BONUS" o "NO BONUS".
            ● Si la línia és "BONUS", l'import associat és un enter aleatori entre 1€ i 10€.
            ● Crea un programa que processi aquest fitxer.
            ● El programa ha de comptar quants bonus s'han distribuït.
            ● També ha de calcular el total de bitllets i el percentatge de bitllets guanyadors.
            ● El fitxer acaba quan es troba un valor null.
            ● També has de calcular el total dels guanys i el nombre de bitllets amb BONUS.
            */

            //Cada vegada que trobem bonus ha de calcular un numero aleatori de entre 1 o 10

            //Declaració de variables
            Console.OutputEncoding = Encoding.Unicode;
            string linia;
            int num, i = 0, billets = 0, guanys = 0;
            Random aleatori = new Random();
            StreamReader fitxer = new StreamReader (@"..\..\..\..\bonus.txt");
            linia = fitxer.ReadLine ();
          
            //Algoritme
            while (linia != null)
            {
                billets++;  //Contador total
                if (linia == "BONUS")
                {
                    num = aleatori.Next(1, 11); //Associem un num aleatori a la variable num
                    i++;                        //contador de bonus
                    guanys += num;              //Aqui es començen a acumular els guanys
                }
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"S`han distribuit: {i} BONUS.\nEn un total de: {billets}.\nAmb un percentatge de billets guanyadors de: {i*100/billets}%.\nEl total de guanys és: {guanys} €.\nI el nombre total de Bonus és: {i}.");
        }
    }
}
