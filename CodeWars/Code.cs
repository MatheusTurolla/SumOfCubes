using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Code
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número do cálculo: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int response = SumCubes(input);

            Console.WriteLine($"Entrada de {input} e saída de {response}");
        }
        public static int SumCubes(int i)
        {
            List<int> numbers, result = new List<int>();
            numbers = Regressao(i);

            foreach(int num in numbers)
            {
                result.Add(num*num*num);
            }
            result.ToArray();

            int soma = 0;
            foreach (int res in result)
            {
                soma += res;
            }
            return soma;
        }

        public static List<int> Regressao(int num)
        {
            List<int> list = new List<int>();
            while (num > 0) 
            {
                list.Add(num);
                num--;
            }
            return list;
        }

    }
}
