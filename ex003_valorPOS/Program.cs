namespace ex003_valorPOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fes un programa per a saber quants valors positius i negatius hem introduït per teclat
            
            //Declaracio de variables
            int numero, contP = 0, contN = 0; //Els contadors SEMPRE COMENÇEN DE 0

            //ENTRADA DE LA INFO
            Console.WriteLine("Escriu el primer valor:");
            numero = Convert.ToInt32(Console.ReadLine());

            //Algoritme //mentre (no final)
            while (numero != 0)
            {
                if (numero < 0)
                    contN++;
                else contP++;

                //demanar seguent
                Console.WriteLine("Escriu un altre valor:");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            //Mostrar el resultat
            Console.WriteLine($"cont pos: {contP} i  {contN} cont neg. ");
        }
    }
}
