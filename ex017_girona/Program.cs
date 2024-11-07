using System.Text;

namespace ex017_girona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4. Hem aconseguit els resultats del girona en un fitxer csv de la temporada 23/24 i reorganitzat
            una mica els partits per a que el girona jugui sempre una jornada com a local i una jornada com
            a visitant (hem reorganitzat les jornades que jugava dues vegades consecutives de visitant o de
            local). 
            Per tant al fitxer Girona lliga23_24.txt acabat amb -1 on trobarem per cada dos files el
            resultat de cada jornada, 
            esent la la primera jornada el Girona jugava al Reale Arena (de visitant) 
            tindrem que els resultats del Girona es troben a les posicions senars (contant com a 0
            la primera entrada del fitxer) i els resultats dels rivals a les posicions parell. 
            Hem de contar quants partits ha guanyats, perduts i empatats el Girona. 
            Si els partits guanyats son 3 punts i els empatats és 1 punt, calcula quants punts va conseguir el Girona la temporada 23/24. */


            //Declaració de variables
            string linia;
            int i = 0, punt = 0, win = 0, empat = 0, perdut=0, puntfinal;
            StreamReader fitxer = new StreamReader(@"..\..\..\..\Girona lliga23_24.txt");
            linia = fitxer.ReadLine();
            
            //Algoritme
            while (linia!=null)
            {
                i++;

                if (i % 2 != 0 || i == 0)
                { 
                    if (linia == "3")
                    {
                        punt += 3;
                        win++;
                    }
                        else if (linia == "2")
                        {
                            punt += 1;
                            empat++;
                        }
                            else if (linia == "1" || linia == "0")
                                perdut++;
                }
                linia = fitxer.ReadLine();
            }

            fitxer.Close();
            Console.WriteLine($"Partits guanyats: {win}.\nPartits perduts: {perdut}.\nPartits empatats: {empat}.\nPunts totals del Girona la temporada 23/24: {punt}");


        }
    }

}
