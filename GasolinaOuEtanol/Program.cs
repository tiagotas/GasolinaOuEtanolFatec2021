using System;

namespace GasolinaOuEtanol
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * O etanol rende 70% em relação a gasolina, ou seja, seum carro faz 100 km com
             * gasolina fará 70 km com etanol. Portanto o preço do etanol não pode ultrapassar
             * 70% do preço da gasolina para ser viável financeiramente.
             * 
             * porcentagem_rendimento_etanol = (preco_etanol * 100) / preco_gasolina
             */
            decimal preco_etanol, preco_gasolina;

            Console.WriteLine("Informe o preço do Etanol: ");
            preco_etanol = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o preço da Gasolina: ");
            preco_gasolina = Convert.ToDecimal(Console.ReadLine());


            decimal porcentagem_rendimento_etanol = (preco_etanol * 100) / preco_gasolina;


            if(porcentagem_rendimento_etanol > 70)
            {
                Console.WriteLine("Compensa a Gasolina.");

            } else
            {
                Console.WriteLine("Compensa o Etanol.");
            }




            Console.ReadKey();
        }
    }
}
