using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Program
    {
        static List<int> SequenciaFibonacci(int n)
        {
            List<int> sequencia = new List<int> { 0, 1 };

            while (true)
            {
                int proximoFib = sequencia[sequencia.Count - 1] + sequencia[sequencia.Count - 2];
                if (proximoFib > n)
                    break;
                sequencia.Add(proximoFib);
            }

            return sequencia;
        }

        static bool ObtencaoSequencia(int n)
        {
            List<int> sequencia = SequenciaFibonacci(n);
            return sequencia.Contains(n);
        }

        static void Main()
        {
            Console.WriteLine("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (ObtencaoSequencia(num))
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {num} NÃO pertence à sequência de Fibonacci.");
            }
        }

    }
}
