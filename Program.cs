using System;

namespace pa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 to exit.");
            int runtimeloop = 1;
            while(runtimeloop > 0){
                Console.Write("Enter Command Code:");
                runtimeloop = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    
}
