using System;

namespace ExexploTratamentoErros
{
    class Program
    {
        static void Main(string[] args)
        {            
            int primeiro = Convert.ToInt32(Console.ReadLine());
            int segundo = Convert.ToInt32(Console.ReadLine());

            double resposta = dividir(primeiro, segundo);
            if (!double.IsNaN(resposta))
            {
                Console.WriteLine(resposta);
            }
            
            Console.Read();
        }

        private static double dividir(int primeiro, int segundo)
        {
            double resposta;
            try
            {
                resposta = primeiro / segundo;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                resposta = double.NaN;
            }
            finally
            {
                Console.WriteLine("Tentativa de Divisão realizada com êxito.");
            }            
            return resposta;
        }
    }
}
