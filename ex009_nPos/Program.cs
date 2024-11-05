namespace ex009_nPos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. Fer un programa que donat un número enter positiu et digui quantes xifres té. 
            //Quina és la condició de final en aquest cas? R: que no sigui igual o més petit que 0.
            
            //iNTRODUCCIÓ de variables
            int num, i = 0;

            //Entrada de la informacio
            Console.WriteLine("Escriu un número enter positiu:");
            num = Convert.ToInt32(Console.ReadLine());

            //Algoritme
            if (num <= 0)  //Si el num es més petit o igual que 0
                Console.WriteLine("Introdueix un número correcte");
             else
                {
                while (num > 0)  //Mentres el num NO sigui més petit que 0, pq si fos mes petit que 0 sería true i sortiria del bucle
                {
                    num /= 10; //Gracies al contador podem saber quantes xifres tindra el numero, al dividir cada vegada entre 10.
                    i++;  
                }
                Console.WriteLine($"El número introduit té: {i} xifres.");
            }
            
        }
    }
}
