namespace ex002_txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Fes el mateix programa però agafant les dades del fitxer NUMEROS.TXT. FI = null.
            string linia;
            int numero, i = 0; //El i es el contador
            StreamReader fitxer = new StreamReader(@"..\..\..\..\NUMEROS.txt");
            linia = fitxer.ReadLine();   //Per llegir la línea
            
            numero = Convert.ToInt32(linia);   //per mostrar amb numeros del fitxer
 
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);   //Per que llegeixi els numeros dels fitxers, ya que nomès són números
                Console.WriteLine(numero);
                i++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"Hem trobat {i} valors.");

            /*Com arribar fins a finals del fitxer:
            while (!fitxer.EndOfStream)
            {
                numero = Convert.ToInt32(fitxer.ReadLine());  
                Console.WriteLine(numero);
            }
            fitxer.Close();

            //Com arribar fins a finals del fitxer BONA:
            //Si arriba al final dona valor NULL, per això nomès les variables tipus strings et permeten identificar  el NULL.

            while (linia != null)
            {
                numero = Convert.ToInt32(linia);   //Per que llegeixi els numeros dels fitxers, ya que nomès són números
                Console.WriteLine(numero);
                i++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();


            //Ara que trobi el numero 0;
            while (linia != null && numero!=0)  //Segueix el programa MENTRES no trobi el null ni el 0.
            {
                numero = Convert.ToInt32(linia);  
                Console.WriteLine(numero);
                i++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
           
            */






        }
    }
}
