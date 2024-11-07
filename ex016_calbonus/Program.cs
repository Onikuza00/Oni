using System.Text;

namespace ex016_calbonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3.Considerem ara el càlcul del BONUS ens apareix en el mateix fitxer, de forma que quan apareix
            la paraula BONUS, garantim que al darrera hi apareix la quantitat guanyada. Si apareix NO
            BONUS, no apareix cap quantitat.
            */
            //Declaració de variables
            Console.OutputEncoding = Encoding.Unicode;
            string linia;
            int num, i = 0, billets = 0, guanys = 0;
            StreamReader fitxer = new StreamReader(@"..\..\..\..\BONUS2.txt");
            linia = fitxer.ReadLine();

            //Algoritme
            while (linia != null)
            {
                billets++;  //Contador total
                if (linia == "BONUS")
                {
                    linia = fitxer.ReadLine();
                    num = Convert.ToInt32(linia); //Associem un num que surt després de BONUS
                    i++;                        //contador de bonus
                    guanys += num;              //Aqui es començen a acumular els guanys
                }
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"S`han distribuit: {i} BONUS.\nEn un total de: {billets}.\nAmb un percentatge de billets guanyadors de: {i * 100 / billets}%.\nEl total de guanys és: {guanys} €.\nI el nombre total de Bonus és: {i}.");
        }
    }
}
