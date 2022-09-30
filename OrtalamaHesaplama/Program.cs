using System;

namespace OrtalamaHesaplama
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sayi giriniz: ");
            int num = int.Parse(Console.ReadLine());   
            
            Calculate.Fibonacci(num);
        }
    }

    public class Calculate
    {
        public static void Fibonacci(int x)
        {
            int[] series = new int[x];

            int a = 0, b = 1, c = 0;

            series[0] = a;
            series[1] = b;
            
            for(int i = 0; i < x; i++)
            {
                c = a + b;
                a = b;
                b = c;
                series[i] = c;
                Console.WriteLine(series[i]);
            }

            double sum = 0;
            double avg = 0;

            for (int i = 0; i < x; i++)
            {
                sum += series[i];
            }
            avg = sum / x;  

            Console.WriteLine(avg);
        } 
    }
}
