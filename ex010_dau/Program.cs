namespace ex010_dau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10. Fes un programa on llancem un dau de 6 cares (valors de forma aleatoria) fins que el número
                  de vegades que surti 1 i 6 sigui el mateix. Conta quantes vegades hem llançat el dau i quantes
                  vegades ha aparegut el valor 6. */

            //Introducció de variables:
            int dau, i = 0, cont1 = 0, cont6 = 0;
            Random tirades = new Random();
            dau = tirades.Next(1, 7);
            
            while (cont1 != cont6 || cont1 == 0 || cont6 == 0)  //Ens asegurem que cont1 y cont6 sigui diferent O (||) cont1 i cont6 sigui igual a 0
                //Aixis es te una versió per entrar la primera vegada i només la primera vegad, per això nomès amb un cont1 == o cont6==0 es suficient.             
            {
                if (dau == 1) cont1++;
                else if (dau == 6) cont6++;
                dau = tirades.Next(1, 7);
                i++;
            }
            Console.WriteLine($"Has  utilitzat: {i} intents, i ha sortit {cont6} vegades, el número 6.");





        }
    }
}
